using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Patterns.Structural.Bridge
{
    class Client
    {
        void Main()
        {
            BridgeImplementation a = new BridgeImplementation(new ImplementationA());
            BridgeImplementation b = new BridgeImplementation(new ImplementationB());

            a.Method1();
            a.Method1();

            b.Method2();
            b.Method2();
        }
    }
}
