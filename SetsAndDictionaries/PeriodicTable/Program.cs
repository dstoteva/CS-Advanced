using System;
using System.Collections.Generic;

namespace PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedSet<string> items = new SortedSet<string>();
            for (int i = 0; i < n; i++)
            {
                string[] element = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                foreach (var item in element)
                {
                    items.Add(item);
                }
            }
            Console.WriteLine(string.Join(" ", items));
        }
    }
}
