using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Patterns.Structural.Decorator
{
    class CheeseDecorator : PizzaDecorator
    {
        public CheeseDecorator(Pizza pizza) : base(pizza)
        {

        }

        public override string GetName()
        {
            return base.GetName() + "cheese";
        }

        public override float GetPrice()
        {
            return base.GetPrice() + 5;
        }
    }
}
