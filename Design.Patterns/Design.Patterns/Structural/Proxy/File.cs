using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Design.Patterns.Structural.Proxy
{
    class File : IFile
    {
        public string FileName { get; set; }


        public void ReadFile(string path)
        {
            System.IO.File.ReadAllBytes(path);
        }
    }
}
