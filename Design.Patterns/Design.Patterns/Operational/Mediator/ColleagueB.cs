using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Patterns.Operational.Mediator
{
    class ColleagueB : Colleague
    {
        public ColleagueB(Mediator mediator) : base(mediator) { }
        public override void Notify(string message)
        {
            Console.WriteLine("Colleague B receive:" + message);
        }
    }
}
