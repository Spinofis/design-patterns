using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Patterns.Constructional.AbstractFactory
{
    abstract class Factory
    {
        public abstract Wheel CreateWheel();
    }
}
