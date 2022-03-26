using System;
using System.Collections.Generic;

namespace CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] symbols = Console.ReadLine().ToCharArray();
            SortedDictionary<char, int> output = new SortedDictionary<char, int>();

            foreach (var item in symbols)
            {
                if (!output.ContainsKey(item))
                {
                    output[item] = new int();
                }
                output[item]++;
            }
            foreach (var kvp in output)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
            }
        }
    }
}
