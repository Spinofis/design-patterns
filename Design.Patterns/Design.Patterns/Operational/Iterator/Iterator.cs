using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Patterns.Operational.Iterator
{
    interface Iterator
    {
        object First();

        object Last();

        object Next();

        object Prev();
    }
}
