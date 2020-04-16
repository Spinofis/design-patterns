using System;

namespace Design.Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            B o = new A();
            Console.WriteLine(o.a);
            Console.WriteLine(o.m());
            Console.ReadKey();
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
