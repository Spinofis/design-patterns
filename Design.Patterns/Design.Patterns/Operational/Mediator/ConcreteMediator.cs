using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Patterns.Operational.Mediator
{
    class ConcreteMediator : Mediator
    {

        public ColleagueA ColleagueA { private get; set; }

        public ColleagueB ColleagueB { private get; set; }

        public void Send(string message, Colleague colleague)
        {
            if (colleague == ColleagueA)
            {
                ColleagueB.Notify(message);
            }
            else
            {
                ColleagueB.Notify(message);
            }
        }
    }
}
