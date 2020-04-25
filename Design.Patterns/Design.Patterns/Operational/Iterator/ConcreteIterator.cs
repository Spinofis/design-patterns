using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Patterns.Operational.Iterator
{
    class ConcreteIterator : Iterator
    {
        private ConcreteAggregate _aggregate;

        private int _curent = 0;

        public ConcreteIterator(ConcreteAggregate aggregte)
        {
            _aggregate = aggregte;
        }

        public object First()
        {
            _curent = 0;
            return _aggregate[0];
        }

        public object Last()
        {
            _curent = _aggregate.Count - 1;
            return _aggregate[_aggregate.Count - 1];
        }

        public object Next()
        {
            if (_curent < _aggregate.Count - 1)
                return _aggregate[++_curent];

            return null;
        }

        public object Prev()
        {
            if (_curent > 0)
                return _aggregate[--_curent];

            return null;
        }
    }
}
