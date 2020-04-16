using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Patterns.Constructional.FabricMethod
{
    class PolishFactory : Factory
    {
        public override Engine CreateEngine()
        {
            return new PolishEngine() { Power = 220 };
        }

        public override Wheel CreateWheel()
        {
            return new PolishWheel() { Radius = 20 };
        }
    }
}
