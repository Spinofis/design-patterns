using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Patterns.Operational.Interpreter
{
    class HoundredExpression : Expression
    {
        protected override string Five()
        {
            return "D";
        }

        protected override string Four()
        {
            return "CD";
        }

        protected override int Multiplier()
        {
            return 100;
        }

        protected override string Nine()
        {
            return "CM";
        }

        protected override string One()
        {
            return "C";
        }
    }
}
