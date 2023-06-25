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

        public int CustomHashFunction(string key)
        {
            char[] character = key.ToCharArray();
            int sumofASCICode = 0;

            foreach (char c in character)
            {
                sumofASCICode += c;
            }
            return sumofASCICode;
        }

        public void Add(string newName)
        {
            int arrayIndex = Math.Abs(CustomHashFunction(newName)) % Names.Length;
            Node newNode = new Node(newName);

            if (Names[arrayIndex] == null)
            {
                Names[arrayIndex] = newNode;
            }
            else
            {
                Node temp = Names[arrayIndex];
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = newNode;
            }

            Console.WriteLine($"{newName} added at index {arrayIndex}");
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
