using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Patterns.Structural.Flyweight
{
    class SomeObject
    {
        public string Value { get; private set; }

        public SomeObject(string value)
        {
            Value = value;
        }
    }
}
