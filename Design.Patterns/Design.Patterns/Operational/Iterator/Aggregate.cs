using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Patterns.Operational.Iterator
{
    interface Aggregate
    {
        Iterator CreateIterator();
    }
}
