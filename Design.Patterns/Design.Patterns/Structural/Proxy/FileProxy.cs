using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Patterns.Structural.Proxy
{
    class FileProxy : IFile
    {
        public string FileName { get; set; }

        private IFile _file;
        
        public void ReadFile(string path)
        {
            if (System.IO.File.Exists(path))
                return;

            _file = new File();
            _file.ReadFile(path);
        }
    }
}
