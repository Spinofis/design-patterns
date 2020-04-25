using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Patterns.Operational.Interpreter
{
    public class Context
    {
        public string Input { get;  set; }

        public int Output { get; set; }

        public Context(string input)
        {
            Input = input;
        }
    }
}
