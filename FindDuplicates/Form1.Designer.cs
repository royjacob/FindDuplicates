namespace FindDuplicatesFiles
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this._browser = new System.Windows.Forms.FolderBrowserDialog();
            this._btnBrowseSource = new System.Windows.Forms.Button();
            this._txtSourceFolder = new System.Windows.Forms.TextBox();
            this._txtLog = new System.Windows.Forms.TextBox();
            this._fileLog = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this._findTab = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this._findButton = new System.Windows.Forms.ToolStripButton();
            this._moveTab = new System.Windows.Forms.TabPage();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this._moveButton = new System.Windows.Forms.ToolStripButton();
            this._moveOperation = new System.Windows.Forms.ToolStripComboBox();
            this._moveProgress = new System.Windows.Forms.ToolStripProgressBar();
            this._tree = new System.Windows.Forms.TreeView();
            this._txtDestinationFolder = new System.Windows.Forms.TextBox();
            this._btnBrowseDestination = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this._findTab.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this._moveTab.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // _btnBrowseSource
            // 
            this._btnBrowseSource.Location = new System.Drawing.Point(521, 8);
            this._btnBrowseSource.Name = "_btnBrowseSource";
            this._btnBrowseSource.Size = new System.Drawing.Size(60, 23);
            this._btnBrowseSource.TabIndex = 0;
            this._btnBrowseSource.Text = "Browse...";
            this._btnBrowseSource.UseVisualStyleBackColor = true;
            this._btnBrowseSource.Click += new System.EventHandler(this.OnBrowseSource);
            // 
            // _txtSourceFolder
            // 
            this._txtSourceFolder.Location = new System.Drawing.Point(78, 10);
            this._txtSourceFolder.Name = "_txtSourceFolder";
            this._txtSourceFolder.Size = new System.Drawing.Size(437, 20);
            this._txtSourceFolder.TabIndex = 1;
            // 
            // _txtLog
            // 
            this._txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this._txtLog.Location = new System.Drawing.Point(0, 0);
            this._txtLog.Multiline = true;
            this._txtLog.Name = "_txtLog";
            this._txtLog.ReadOnly = true;
            this._txtLog.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this._txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this._txtLog.Size = new System.Drawing.Size(545, 163);
            this._txtLog.TabIndex = 3;
            // 
            // _fileLog
            // 
            this._fileLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this._fileLog.Location = new System.Drawing.Point(0, 0);
            this._fileLog.Multiline = true;
            this._fileLog.Name = "_fileLog";
            this._fileLog.ReadOnly = true;
            this._fileLog.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this._fileLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this._fileLog.Size = new System.Drawing.Size(545, 159);
            this._fileLog.TabIndex = 4;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(3, 31);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this._txtLog);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this._fileLog);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(545, 326);
            this.splitContainer1.SplitterDistance = 163;
            this.splitContainer1.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this._findTab);
            this.tabControl1.Controls.Add(this._moveTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 62);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(559, 386);
            this.tabControl1.TabIndex = 6;
            // 
            // _findTab
            // 
            this._findTab.Controls.Add(this.toolStrip1);
            this._findTab.Controls.Add(this.splitContainer1);
            this._findTab.Location = new System.Drawing.Point(4, 22);
            this._findTab.Name = "_findTab";
            this._findTab.Padding = new System.Windows.Forms.Padding(3);
            this._findTab.Size = new System.Drawing.Size(551, 360);
            this._findTab.TabIndex = 0;
            this._findTab.Text = "Find Duplicates";
            this._findTab.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._findButton});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(545, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // _findButton
            // 
            this._findButton.Image = ((System.Drawing.Image)(resources.GetObject("_findButton.Image")));
            this._findButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._findButton.Name = "_findButton";
            this._findButton.Size = new System.Drawing.Size(50, 22);
            this._findButton.Text = "Find";
            this._findButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this._findButton.Click += new System.EventHandler(this.OnFileDuplicates);
            // 
            // _moveTab
            // 
            this._moveTab.Controls.Add(this.toolStrip2);
            this._moveTab.Controls.Add(this._tree);
            this._moveTab.Location = new System.Drawing.Point(4, 22);
            this._moveTab.Name = "_moveTab";
            this._moveTab.Padding = new System.Windows.Forms.Padding(3);
            this._moveTab.Size = new System.Drawing.Size(551, 360);
            this._moveTab.TabIndex = 1;
            this._moveTab.Text = "Move Duplicates";
            this._moveTab.UseVisualStyleBackColor = true;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._moveButton,
            this._moveOperation,
            this._moveProgress});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(545, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // _moveButton
            // 
            this._moveButton.Image = ((System.Drawing.Image)(resources.GetObject("_moveButton.Image")));
            this._moveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._moveButton.Name = "_moveButton";
            this._moveButton.Size = new System.Drawing.Size(57, 22);
            this._moveButton.Text = "Move";
            this._moveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this._moveButton.Click += new System.EventHandler(this.OnMoveDuplicates);
            // 
            // _moveOperation
            // 
            this._moveOperation.Items.AddRange(new object[] {
            "Test",
            "Copy",
            "Move"});
            this._moveOperation.Name = "_moveOperation";
            this._moveOperation.Size = new System.Drawing.Size(121, 25);
            // 
            // _moveProgress
            // 
            this._moveProgress.Name = "_moveProgress";
            this._moveProgress.Size = new System.Drawing.Size(100, 22);
            // 
            // _tree
            // 
            this._tree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tree.Location = new System.Drawing.Point(3, 31);
            this._tree.Name = "_tree";
            this._tree.Size = new System.Drawing.Size(545, 326);
            this._tree.TabIndex = 0;
            // 
            // _txtDestinationFolder
            // 
            this._txtDestinationFolder.Location = new System.Drawing.Point(78, 36);
            this._txtDestinationFolder.Name = "_txtDestinationFolder";
            this._txtDestinationFolder.Size = new System.Drawing.Size(437, 20);
            this._txtDestinationFolder.TabIndex = 8;
            // 
            // _btnBrowseDestination
            // 
            this._btnBrowseDestination.Location = new System.Drawing.Point(521, 34);
            this._btnBrowseDestination.Name = "_btnBrowseDestination";
            this._btnBrowseDestination.Size = new System.Drawing.Size(60, 23);
            this._btnBrowseDestination.TabIndex = 7;
            this._btnBrowseDestination.Text = "Browse...";
            this._btnBrowseDestination.UseVisualStyleBackColor = true;
            this._btnBrowseDestination.Click += new System.EventHandler(this.OnDestinationBrowse);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Source:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Destination:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 460);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._txtDestinationFolder);
            this.Controls.Add(this._btnBrowseDestination);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this._txtSourceFolder);
            this.Controls.Add(this._btnBrowseSource);
            this.MinimumSize = new System.Drawing.Size(583, 338);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this._findTab.ResumeLayout(false);
            this._findTab.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this._moveTab.ResumeLayout(false);
            this._moveTab.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog _browser;
        private System.Windows.Forms.Button _btnBrowseSource;
        private System.Windows.Forms.TextBox _txtSourceFolder;
        private System.Windows.Forms.TextBox _txtLog;
        private System.Windows.Forms.TextBox _fileLog;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabPage _findTab;
        private System.Windows.Forms.TabPage _moveTab;
        private System.Windows.Forms.TreeView _tree;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton _findButton;
        private System.Windows.Forms.TextBox _txtDestinationFolder;
        private System.Windows.Forms.Button _btnBrowseDestination;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton _moveButton;
        private System.Windows.Forms.ToolStripComboBox _moveOperation;
        private System.Windows.Forms.ToolStripProgressBar _moveProgress;
    }
}

