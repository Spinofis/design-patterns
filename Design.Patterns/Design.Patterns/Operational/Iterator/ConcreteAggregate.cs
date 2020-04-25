using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Patterns.Operational.Iterator
{
    class ConcreteAggregate : Aggregate
    {
        List<object> _items = new List<object>();

        public object this[int index]
        {
            get { return _items[index]; }
            set { _items.Insert(index, value); }
        }

        public int Count
        {
            get { return _items.Count; }
        }

        public Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }
    }
}
