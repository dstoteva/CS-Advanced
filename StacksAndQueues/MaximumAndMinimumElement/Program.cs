using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int command = nums[0];
                switch (command)
                {
                    case 1:
                        stack.Push(nums[1]);
                        break;
                    case 2:
                        if (stack.Count > 0)
                        {
                            stack.Pop();
                        }
                       
                        break;
                    case 3:
                        if (stack.Count > 0)
                        {
                            Console.WriteLine(stack.Max());
                        }    
                        break;
                    case 4:
                        if (stack.Count > 0)
                        {
                            Console.WriteLine(stack.Min());
                        }    
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
