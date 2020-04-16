using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Patterns.Constructional.Builder
{
    class Director
    {
        public Product BuildProduct(IBuilder builder)
        {
            builder.BuildPart_A();
            builder.BuildPart_B();

            return builder.GetProduct();
        }
    }
}
