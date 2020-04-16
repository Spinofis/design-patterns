using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Patterns.Structural.Decorator
{
    public class PizzaDecorator : Pizza
    {
        protected Pizza _pizza;

        public PizzaDecorator(Pizza pizza)
        {
            _pizza = pizza;
        }

        public override string GetName()
        {
            return _pizza.GetName();
        }

        public override float GetPrice()
        {
            return _pizza.GetPrice();
        }
    }
}
