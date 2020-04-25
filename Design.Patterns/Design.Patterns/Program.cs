using System;

namespace Design.Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Operational.Interpreter.Client client = new Operational.Interpreter.Client("MCMXXVIII");
            client.RomanToDecimal();
        }
    }

    public class A : B
    {
        public string a = "A";

        public override string m()
        {
            return "a";
        }
    }

    public class B
    {
        public string a = "B";

        public virtual string m()
        {
            return "b";
        }
    }
}
