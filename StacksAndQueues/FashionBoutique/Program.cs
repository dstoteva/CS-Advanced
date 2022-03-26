using System;
using System.Collections.Generic;
using System.Linq;

namespace FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int capacity = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>(clothes);
            int count = 1;
            int currentRack = 0;

            while (stack.Count > 0)
            {
                int currentClothes = stack.Pop();
                if (currentRack + currentClothes > capacity)
                {
                    count++;
                    currentRack = currentClothes;
                }
                else
                {
                    currentRack += currentClothes;
                }
            }
            Console.WriteLine(count);
        }
    }
}
