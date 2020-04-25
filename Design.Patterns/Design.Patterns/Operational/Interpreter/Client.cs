using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Patterns.Operational.Interpreter
{
    class Client
    {
        public string Roman { get; private set; }

        public Client(string roman)
        {
            Roman = roman;
        }

        public void RomanToDecimal()
        {
            //string roman = "MCMXXVIII";
            Context context = new Context(Roman);

            List<Expression> expressions = new List<Expression> { new ThousandExpression(), new HoundredExpression(), new TenExpression(), new OneExpression() };

            foreach (var ex in expressions)
            {
                ex.Interpret(context);
            }

            Console.WriteLine(Roman + " = " + context.Output);
            Console.ReadKey();
        }
    }
}
