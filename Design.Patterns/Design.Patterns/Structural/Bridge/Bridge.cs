namespace Design.Patterns.Structural.Bridge
{
    abstract class Bridge
    {
        protected ISomeInterface implementation;

        public Bridge(ISomeInterface implementation)
        {
            this.implementation = implementation;
        }

        public abstract void Method1();

        public abstract void Method2();
    }
}
