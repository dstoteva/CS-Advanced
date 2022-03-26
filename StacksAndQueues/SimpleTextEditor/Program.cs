using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<string> stack = new Stack<string>();
            var sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                string[] inputLine = Console.ReadLine().Split();

                string command = inputLine[0];

                switch (command)
                {
                    case "1":
                        stack.Push(sb.ToString());
                        sb.Append(inputLine[1]);
                        break;
                    case "2":
                        stack.Push(sb.ToString());
                        int count = int.Parse(inputLine[1]);
                        sb.Remove(sb.Length - count, count);
                        break;
                    case "3":
                        int index = int.Parse(inputLine[1]) - 1;
                        Console.WriteLine(sb[index]);
                        break;
                    case "4":
                        sb.Clear();
                        sb.Append(stack.Pop());
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
