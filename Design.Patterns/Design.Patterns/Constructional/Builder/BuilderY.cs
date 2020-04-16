using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Patterns.Constructional.Builder
{
    class BuilderY : IBuilder
    {
        private Product _product = new Product();

        public void BuildPart_A()
        {
            _product.PartA = "Pink";
        }

        public void BuildPart_B()
        {
            _product.PartA = "Black";
        }

        public Product GetProduct()
        {
            return _product;
        }
    }
}
