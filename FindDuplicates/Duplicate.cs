using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindDuplicatesFiles
{
    internal class Duplicate
    {
        FileInfo _file;
        List<FileInfo> _duplicates;
        internal Duplicate(FileInfo dupeOf)
        {
            _file = dupeOf;
        }

        internal void AddDuplicate(FileInfo dupe)
        {
            if (_duplicates == null)
            {
                _duplicates = new List<FileInfo>();
            }
            _duplicates.Add(dupe);
        }

        public override string ToString()
        {
            return _file.Name;
        }

        public IEnumerable<FileInfo> DuplicateFiles
        {
            get { return _duplicates; }
        }
    }
}
