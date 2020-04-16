using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Patterns.Constructional.FabricMethod
{
    abstract class Factory
    {
        public abstract Wheel CreateWheel();

        public abstract Engine CreateEngine();
    }
}
