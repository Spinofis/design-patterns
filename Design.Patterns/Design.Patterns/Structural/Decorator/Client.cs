using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Patterns.Structural.Decorator
{
    class Client
    {
        Pizza bigPizza = new BigPizza();
        Pizza bigPizzaWithCheese;

        public Client()
        {
            bigPizzaWithCheese = new CheeseDecorator(bigPizza);
        }
    }
}
