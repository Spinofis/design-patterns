using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Patterns.Constructional.Builder
{
    class BuilderX : IBuilder
    {
        private Product _product = new Product();

        public void BuildPart_A()
        {
            _product.PartA = "Green";
        }

        public void BuildPart_B()
        {
            _product.PartB = "Yellow";
        }

        public Product GetProduct()
        {
            return _product;
        }
    }
}
