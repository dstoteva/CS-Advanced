using System;
using System.Collections.Generic;
using System.Linq;

namespace StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(nums);

            while (true)
            {
                string[] command = Console.ReadLine().Split();
                string word = command[0].ToLower();
                if (word == "end")
                {
                    break;
                }
                int firstNum = int.Parse(command[1]);

                if (word == "add")
                {
                    stack.Push(firstNum);
                    stack.Push(int.Parse(command[2]));
                }
                else if (word == "remove" && stack.Count >= firstNum)
                {
                    for (int i = 0; i < firstNum; i++)
                    {
                        stack.Pop();
                    }
                }
            }
            int sum = 0;
            while (stack.Count > 0)
            {
                sum += stack.Pop();
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
