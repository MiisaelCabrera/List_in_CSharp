using System;
using System.Collections.Generic;
using System.Text;

namespace List_in_cSharp
{
    class Node
    {
        internal string data;
        internal Node next;
        internal Node previous;

        public Node(string data)
        {
            this.data = data;
        }
    }
}
