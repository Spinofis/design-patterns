using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Patterns.Operational.Interpreter
{
    class ThousandExpression : Expression
    {
        protected override string Five()
        {
            return " ";
        }

        protected override string Four()
        {
            return " ";
        }

        protected override int Multiplier()
        {
            return 1000;
        }

        protected override string Nine()
        {
            return " ";
        }

        protected override string One()
        {
            return "M";
        }
    }
}
