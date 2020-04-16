using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Patterns.Constructional.AbstractFactory
{
    class Client
    {
        private List<Wheel> _wheels = new List<Wheel>();

        public void OrderWheel(Factory factory)
        {
            _wheels.Add(factory.CreateWheel());
        }
    }
}
