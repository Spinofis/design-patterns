using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Patterns.Operational.Mediator
{
    abstract class Mediator
    {
        public abstract void Send(string message, Colleague colleague);
    }
}
