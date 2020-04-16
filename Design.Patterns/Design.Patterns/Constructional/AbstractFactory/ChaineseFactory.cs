using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Patterns.Constructional.AbstractFactory
{
    class ChaineseFactory : Factory
    {
        public override Wheel CreateWheel()
        {
            return new ChaineseWheel() { Radius = 12 };
        }
    }
}
