namespace DND10_CustomHashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomHashTable customHashTable = new CustomHashTable(7);

            customHashTable.Add("Apple");
            customHashTable.Add("Orange");
            customHashTable.Add("Kiwi");
            customHashTable.Add("Mango");

            customHashTable.Display();
        }
    }
}