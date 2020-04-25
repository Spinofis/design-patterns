using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Patterns.Operational.ChainOfResponsibility
{
    class Client
    {
        public void Main()
        {
            Handler hA = new HandlerA();
            Handler hB = new HandlerB();
            Handler hC = new HandlerC();

            hA.SetSuccessor(hB);
            hB.SetSuccessor(hC);

            int[] reuestes = { 1, 5, 11, 13, 25 };

            foreach (int r in reuestes)
            {
                hA.HandleRequest(r);
            }
        }
    }
}
