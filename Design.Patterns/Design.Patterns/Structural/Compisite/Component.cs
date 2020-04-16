using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Patterns.Structural.Compisite
{
    abstract class Component
    {
        public abstract void Display();

        public virtual void Add(Component component)
        {

        }

        public virtual void Remove(Component component)
        {

        }
    }
}
