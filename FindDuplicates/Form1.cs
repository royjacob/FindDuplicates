using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindDuplicatesFiles
{
    public partial class Form1 : Form
    {
        string numeric = "0123456789";
        char[] numericArray = new char[]{'0','1','2','3','4','5','6','7','8','9'};
        Dictionary<string, Dir> _found;
        internal enum MoveOp
        {
            Test,
            Copy,
            Move
        }

        public Form1()
        {
            InitializeComponent();
            _txtSourceFolder.Text = @"\\stora\FamilyLibrary\FamilyMusic\Music\Florence + The Machine";
            _txtDestinationFolder.Text = @"C:\Users\roy\TestData";
            _moveOperation.SelectedIndex = (int)MoveOp.Test;
        }

        private void FindDuplicates()
        {
            if (!string.IsNullOrEmpty(_txtSourceFolder.Text) && Directory.Exists(_txtSourceFolder.Text))
            {
                _findButton.Enabled = false;
                DirectoryInfo dir = new DirectoryInfo(_txtSourceFolder.Text);
                Dictionary<string, Dir> found = new Dictionary<string, Dir>();
                ThreadPool.QueueUserWorkItem((object state) =>
                    {
                        ProcessDirectory(dir, found);
                        _found = found;
                        Invoke((MethodInvoker)delegate 
                        {
                            _findButton.Enabled = true;
                            UpdateTree();
                        });
                    }
                );
            }
        }

        private void MoveDuplicates()
        {
            MoveOp op = (MoveOp)_moveOperation.SelectedIndex;
            if (!string.IsNullOrEmpty(_txtSourceFolder.Text) && Directory.Exists(_txtSourceFolder.Text))
            {
                _moveButton.Enabled = false;
                int count = 0;
                foreach (Dir directory in _found.Values)
                {
                    foreach (Duplicate dupe in directory.Dupes)
                    {
                        count += dupe.DuplicateFiles.Count();
                    }
                }
                _moveProgress.Maximum = count;

                string srcFolder = _txtSourceFolder.Text;
                string dstRoot = _txtDestinationFolder.Text;
                if (!string.IsNullOrEmpty(_txtDestinationFolder.Text) && Directory.Exists(_txtDestinationFolder.Text))
                {
                    ThreadPool.QueueUserWorkItem((object state) =>
                        {
                            ProcessDuplicates(op, srcFolder, dstRoot);
                            Invoke((MethodInvoker)delegate
                            {
                                _moveButton.Enabled = true;
                                UpdateTree();
                            });
                        }
                    );
                }
            }
        }

        private void ProcessDuplicates(MoveOp op, string srcFolder, string dstRoot)
        {
            int progress = 0;
            foreach (Dir directory in _found.Values)
            {
                string dest = directory.GetDirectory(srcFolder).TrimStart('\\');
                string destFolder = Path.Combine(dstRoot, dest);
                if (!Directory.Exists(destFolder))
                {
                    Directory.CreateDirectory(destFolder);
                }
                foreach (Duplicate dupe in directory.Dupes)
                {
                    foreach (FileInfo file in dupe.DuplicateFiles)
                    {
                        string destFile = Path.Combine(destFolder, file.Name);
                        switch(op)
                        {
                            case MoveOp.Test:
                                using (StreamWriter wrt = File.AppendText(destFile))
                                {
                                    wrt.Write("");
                                }
                                break;
                            case MoveOp.Move:
                                File.Copy(file.FullName, destFile); 
                                file.Delete();
                                break;
                            case MoveOp.Copy:
                                File.Copy(file.FullName, destFile); 
                                break;
                        }
                        UpdateProgress(++progress);
                    }
                }
            }
        }

        private void UpdateProgress(int prog)
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)delegate { UpdateProgress(prog); });
            }
            else
            {
                _moveProgress.Value = prog;
            }
        }
        
        private void UpdateTree()
        {
            _tree.BeginUpdate();
            _tree.Nodes.Clear();
            foreach(Dir directory in _found.Values)
            {
                TreeNode dirNode = new TreeNode(directory.ToString()) { Tag = directory };
                foreach (Duplicate dupe in directory.Dupes)
                {
                    TreeNode fileNode = new TreeNode(dupe.ToString()) { Tag = dupe };
                    foreach (FileInfo file in dupe.DuplicateFiles)
                    {
                        TreeNode dupeNode = new TreeNode(file.Name) { Tag = file };
                        fileNode.Nodes.Add(dupeNode);
                    }
                    dirNode.Nodes.Add(fileNode);                    
                }
                _tree.Nodes.Add(dirNode); 
            }
            _tree.EndUpdate();
        }

        private void ProcessDirectory(DirectoryInfo dirInfo, Dictionary<string, Dir> found)
        {
            Log(dirInfo);
            IEnumerable<FileSystemInfo> infos = dirInfo.EnumerateFileSystemInfos();
            List<DirectoryInfo> dirs = new List<DirectoryInfo>(); 
            foreach (FileSystemInfo inf in infos)
            {
                if (inf.Attributes.HasFlag(FileAttributes.Directory))
                {
                    dirs.Add(new DirectoryInfo(inf.FullName));
                }
                else if (inf.Attributes == FileAttributes.Normal)
                {
                    FileInfo fInfo = new FileInfo(inf.FullName);
                    Test(fInfo, found);
                }
            }

            foreach (DirectoryInfo dir in dirs)
            {
                ProcessDirectory(dir, found);
            }
        }

        private void Test(FileInfo file, Dictionary<string, Dir> found)
        {
            string noExt = file.Name.Substring(0, file.Name.IndexOf(file.Extension));
            int num = numeric.IndexOf(noExt.TrimEnd(' ').Last(), 0);
            if ( num > -1)
            {
                int idxNum = noExt.IndexOf(numeric.ElementAt(num));
                if (idxNum >= 0)
                {
                    string name = noExt.TrimEnd(numericArray).TrimEnd(' ');

                    string path = Path.Combine(file.DirectoryName, name + file.Extension );
                    FileInfo originalFile = new FileInfo(path);
                    if (originalFile.Exists)
                    {
                        Dir foundItems;
                        if (!found.TryGetValue(file.DirectoryName, out foundItems))
                        {
                            foundItems = new Dir(file.Directory);
                            found[file.DirectoryName] = foundItems;
                        }
                        foundItems.AddDuplicate(originalFile, file);
                        Log(file, originalFile.Name);
                    }
                }
            }
        }


        private void Log(DirectoryInfo dir)
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)delegate { Log(dir); });
            }
            else
            {
                _txtLog.AppendText(dir.FullName + Environment.NewLine);
            }
        }

        private void Log(FileInfo file, string normal)
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)delegate { Log(file, normal); });
            }
            else
            {
                _fileLog.AppendText(string.Format("{0} -> {1}{2}", file.Name, normal, Environment.NewLine));
            }
        }

        private void OnFileDuplicates(object sender, EventArgs e)
        {
            FindDuplicates();
        }

        private void OnMoveDuplicates(object sender, EventArgs e)
        {
            MoveDuplicates();
        }
 
        private void OnBrowseSource(object sender, EventArgs e)
        {
            DialogResult result = _browser.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                _txtSourceFolder.Text = _browser.SelectedPath;
            }
        }

        private void OnDestinationBrowse(object sender, EventArgs e)
        {
            DialogResult result = _browser.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                _txtDestinationFolder.Text = _browser.SelectedPath;
            }
        }

    }

}
