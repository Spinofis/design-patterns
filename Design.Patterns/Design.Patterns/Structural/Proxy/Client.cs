using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Patterns.Structural.Proxy
{
    class Client
    {
        void Main()
        {
            IFile file = new FileProxy();
            file.ReadFile("");
        }
    }
}

