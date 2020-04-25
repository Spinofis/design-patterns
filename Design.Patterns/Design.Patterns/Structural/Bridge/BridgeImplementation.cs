using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Patterns.Structural.Bridge
{
    class BridgeImplementation : Bridge
    {
        public BridgeImplementation(ISomeInterface implementation) : base(implementation) { }

        public override void Method1()
        {
            implementation.Method1();
        }

        public override void Method2()
        {
            implementation.Method2();
        }
    }
}
