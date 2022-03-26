using System;
using System.Collections.Generic;
using System.Linq;

namespace TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<int> queue = new Queue<int>();
            int index = -1;
            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                queue.Enqueue(input[0] - input[1]);
            }
            for (int i = 0; i < n; i++)
            {
                index = i;
                int sum = 0;
                bool fullCycle = true;

                for (int j = 0; j < n; j++)
                {
                    int station = queue.Dequeue();
                    sum += station;
                    if (sum < 0)
                    {
                        fullCycle = false;
                    }
                    queue.Enqueue(station);
                }
                queue.Enqueue(queue.Dequeue());
                if (fullCycle == true)
                {
                    Console.WriteLine(index);
                    return;
                }
            }
        }
    }
}
