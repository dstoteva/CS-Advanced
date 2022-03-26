using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0];
            int s = input[1];
            int x = input[2];

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(numbers);
            for (int i = 0; i < s; i++)
            {
                stack.Pop();
            }
            if (stack.Count == 0)
            {
                Console.WriteLine(0);
                return;
            }
            int smallest = int.MaxValue;
            bool containsX = false;

            while (stack.Count > 0)
            {
                int current = stack.Pop();
                if (current < smallest)
                {
                    smallest = current;
                }
                if (current == x)
                {
                    containsX = true;
                    Console.WriteLine("true");
                    break;
                }
            }
            if (containsX == false)
            {
                    Console.WriteLine(smallest);
            }
            
        }
    }
}
