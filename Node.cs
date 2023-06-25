using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND10_CustomHashTable
{
    internal class Node
    {
        public string Data;
        public Node Next;

        public Node(string data)
        {
            Data = data;
        }
    }
}
