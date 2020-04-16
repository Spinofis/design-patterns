using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Patterns.Structural.Decorator
{
    class BigPizza : Pizza
    {
        public override string GetName()
        {
            return "Big pizza";
        }

        public override float GetPrice()
        {
            return 40;
        }
    }
}
