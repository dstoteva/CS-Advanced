using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            HashSet<int> nNums = new HashSet<int>();
            HashSet<int> mNums = new HashSet<int>();
            int n = input[0];
            int m = input[1];

            for (int i = 0; i < n + m; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (i < n)
                {
                    nNums.Add(num);
                }
                else if (i >= n)
                {
                    mNums.Add(num);
                }
            }

            foreach (var item in nNums)
            {
                if (mNums.Contains(item))
                {
                    Console.Write(item + " ");
                }
            }
        }
    }
}
