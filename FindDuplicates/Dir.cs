using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindDuplicatesFiles
{
    internal class Dir
    {
        DirectoryInfo _dir;
        Dictionary<string, Duplicate> _duplicates;
        internal Dir(DirectoryInfo dir)
        {
            _dir = dir;
        }

        internal void AddDuplicate(FileInfo dupeOf, FileInfo dupeFile)
        {
            Duplicate dupe;
            if (_duplicates == null)
            {
                _duplicates = new Dictionary<string, Duplicate>();
            }
            if (!_duplicates.TryGetValue(dupeOf.Name, out dupe))
            {
                dupe = new Duplicate(dupeOf);
                _duplicates[dupeOf.Name] = dupe;
            }
            dupe.AddDuplicate(dupeFile);
        }

        public override string ToString()
        {
            return _dir.FullName;
        }

        public string GetDirectory(string source)
        {
            return _dir.FullName.Substring(source.Length);
        }

        public IEnumerable<Duplicate> Dupes
        {
            get
            {
                return _duplicates.Values;
            }
        }
    }
}
