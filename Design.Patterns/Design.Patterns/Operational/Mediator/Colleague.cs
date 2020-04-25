using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Patterns.Operational.Mediator
{
    abstract class Colleague
    {
        private Mediator _mediator;

        public Colleague(Mediator mediator)
        {
            _mediator = mediator;
        }

        public abstract void Notify(string message);
    }
}
