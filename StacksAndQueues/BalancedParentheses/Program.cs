using System;
using System.Collections.Generic;
using System.Linq;

namespace BalancedParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> stack = new Stack<char>();
            if (input.Length % 2 == 1)
            {
                Console.WriteLine("NO");
                return;
            }

            bool isEqual = true;

            foreach (var ch in input)
            {
                switch (ch)
                {
                    case '(':
                    case '{':
                    case '[':
                        stack.Push(ch);
                        break;
                    case ')':
                        if (stack.Any() && stack.Pop() != '(')
                        {
                            isEqual = false;
                        }
                        break;
                    case '}':
                        if (stack.Any() && stack.Pop() != '{')
                        {
                            isEqual = false;
                        }
                        break;
                    case ']':
                        if (stack.Any() && stack.Pop() != '[')
                        {
                            isEqual = false;
                        }
                        break;
                }
                if (!isEqual)
                {
                    Console.WriteLine("NO");
                    return;
                }
            }
            Console.WriteLine("YES");
        }
    }
}
