using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Patterns.Constructional.AbstractFactory
{
    class PolishFactory : Factory
    {
        public override Wheel CreateWheel()
        {
            return new PolishWheel() { Radius = 20 };
        }
    }
}
