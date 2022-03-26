using System;
using System.Collections.Generic;
using System.Linq;

namespace Socks
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> leftSocks = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            Queue<int> rightSocks = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

            List<int> pairs = new List<int>();

            while (leftSocks.Count != 0 || rightSocks.Count != 0)
            {
                if (leftSocks.Peek() > rightSocks.Peek())
                {
                    pairs.Add(leftSocks.Pop() + rightSocks.Dequeue());
                }
                else if (rightSocks.Peek() > leftSocks.Peek())
                {
                    leftSocks.Pop();
                }
                else
                {
                    rightSocks.Dequeue();
                    int sock = leftSocks.Pop();
                    leftSocks.Push(sock + 1);
                }
            }
            Console.WriteLine(pairs.Max());
            Console.WriteLine(string.Join(" ", pairs));
        }
    }
}
