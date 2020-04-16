using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Patterns.Structural.Adapter
{
    class Adapter : IClientInterface
    {
        private Adaptee _adaptee;

        public Adapter()
        {
        }

        public void ClientMethod()
        {
            _adaptee.MyMethod();
        }
    }
}
