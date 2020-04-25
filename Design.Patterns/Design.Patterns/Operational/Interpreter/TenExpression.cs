using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Patterns.Operational.Interpreter
{
    class TenExpression : Expression
    {
        protected override string Five()
        {
            return "L";
        }

        protected override string Four()
        {
            return "XL";
        }

        protected override int Multiplier()
        {
            return 10;
        }

        protected override string Nine()
        {
            return "XC";
        }

        protected override string One()
        {
            return "X";
        }
    }
}
