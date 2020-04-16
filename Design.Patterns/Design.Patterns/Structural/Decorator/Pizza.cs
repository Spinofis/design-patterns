using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Patterns.Structural.Decorator
{
    public abstract class Pizza
    {
        public abstract string GetName();

        public abstract float GetPrice();
    }
}
