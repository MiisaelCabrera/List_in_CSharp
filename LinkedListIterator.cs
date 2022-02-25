using System;
using System.Collections.Generic;
using System.Text;

namespace List_in_cSharp
{
    class LinkedListIterator
    {
        private Node currentNode;

        public LinkedListIterator(Node startNode)
        {
            currentNode = startNode;
        }

        public bool hasNext()
        {
            return currentNode != null;
        }

        public string next()
        {
            string data = currentNode.data;

            currentNode = currentNode.next;

            return data;
        }
    }
}
