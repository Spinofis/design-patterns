using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Design.Patterns.Structural.Flyweight
{
    class FlyweightFactory
    {
        List<SomeObject> someObjects = new List<SomeObject>();

        public SomeObject GetSomeObject(string value)
        {
            var someObject = someObjects.Where(x => x.Value.Equals(value)).FirstOrDefault();

            if (someObject == null)
            {
                someObject = new SomeObject(value);
                someObjects.Add(someObject);
                return someObject;
            }
            else
                return someObject;
        }
    }
}
