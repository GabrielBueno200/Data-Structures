using System;
using Structure.Entities;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new LinkedList<string>();

            list.Append("as2");
            list.Append("fg3");
            list.Append("vb5");
            list.Append("gf6");

            Console.WriteLine(list.GetAt(1));

            Console.WriteLine(list);

            Console.WriteLine($"Size: {list.Count}");

            list.RemoveAt(2);

            Console.WriteLine(list);

            Console.WriteLine($"Size: {list.Count}");
        }
    }
}
