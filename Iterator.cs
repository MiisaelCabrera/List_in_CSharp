using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_in_cSharp
{
    internal interface Iterator<T>
    {
        bool hasNext();
        T next();
    }
}