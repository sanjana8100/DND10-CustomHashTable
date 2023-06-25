using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND10_CustomHashTable
{
    internal class CustomHashTable
    {
        private Node[] Names;

        public CustomHashTable(int size)
        {
            Names = new Node[size];
        }

        public void Display()
        {
            for (int i = 0; i < Names.Length; i++)
            {
                Node temp = Names[i];
                Console.Write($"Index {i}: ");
                while (temp != null)
                {
                    Console.Write(temp.Data + " -> ");
                    temp = temp.Next;
                }
                Console.WriteLine("null");
            }
        }
    }
}
