using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Patterns.Constructional.Builder
{
    interface IBuilder
    {
        void BuildPart_A();

        void BuildPart_B();

        Product GetProduct();
    }
}
