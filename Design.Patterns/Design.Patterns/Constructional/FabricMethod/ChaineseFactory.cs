using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Patterns.Constructional.FabricMethod
{
    class ChaineseFactory : Factory
    {
        public override Engine CreateEngine()
        {
            return new ChineseEngine() { Power = 100 };
        }

        public override Wheel CreateWheel()
        {
            return new ChaineseWheel() { Radius = 12 };
        }
    }
}
