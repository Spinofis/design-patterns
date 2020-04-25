using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Patterns.Operational.ChainOfResponsibility
{
    abstract class Handler
    {
        protected Handler successor;

        public abstract void HandleRequest(int i);

        public void SetSuccessor(Handler successor)
        {
            this.successor = successor;
        }
    }
}
