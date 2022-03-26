using System;
using System.Collections.Generic;

namespace HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            Queue<string> children = new Queue<string>(input);

            int num = int.Parse(Console.ReadLine());
            int count = 1;

            while (children.Count > 1)
            {
                var currentChild = children.Dequeue();

                if (count % num != 0)
                {
                    children.Enqueue(currentChild);
                }
                else
                {
                    Console.WriteLine($"Removed {currentChild}");
                }
                count++;
            }
            Console.WriteLine($"Last is {children.Dequeue()}");
        }
    }
}
