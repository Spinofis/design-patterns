using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Patterns.Structural.Proxy
{
    interface IFile
    {
        public string FileName { get; set; }

        void ReadFile(string path);
    }
}
