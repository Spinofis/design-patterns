using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Patterns.Operational.Mediator
{
    class ColleagueA : Colleague
    {
        public ColleagueA(Mediator mediator) : base(mediator) { }

        public override void Notify(string message)
        {
            Console.WriteLine("Colleague A receive:" + message);
        }
    }
}
