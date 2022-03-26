using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0];
            int s = input[1];
            int x = input[2];
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int smallest = int.MaxValue;
            Queue<int> queue = new Queue<int>(nums);

            for (int i = 0; i < s; i++)
            {
                queue.Dequeue();
            }
            if (queue.Count == 0)
            {
                Console.WriteLine(0);
                return;
            }

            while (queue.Count > 0)
            {
                int current = queue.Dequeue();
                if (current == x)
                {
                    Console.WriteLine("true");
                    return;
                }
                if (current < smallest)
                {
                    smallest = current;
                }
            }

            Console.WriteLine(smallest);
        }
    }
}
