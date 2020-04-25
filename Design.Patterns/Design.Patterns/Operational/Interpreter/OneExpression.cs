using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Patterns.Operational.Interpreter
{
    class OneExpression : Expression
    {
        protected override string Five()
        {
            return "V";
        }

        protected override string Four()
        {
            return "IV";
        }

        protected override int Multiplier()
        {
            return 1;
        }

        protected override string Nine()
        {
            return "IX";
        }

        protected override string One()
        {
            return "I";
        }
    }
}
