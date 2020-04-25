using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Patterns.Operational.ChainOfResponsibility
{
    class HandlerB : Handler
    {
        public override void HandleRequest(int i)
        {
            if (i >= 10 && i < 20)
            {
                Console.WriteLine("{0} handled by {1}", i, this.GetType().Name);
            }
            else if (successor != null)
            {
                successor.HandleRequest(i);
            }
        }
    }
}
