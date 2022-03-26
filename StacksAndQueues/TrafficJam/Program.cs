using System;
using System.Collections.Generic;

namespace TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();
            int count = 0;

            while (true)
            {
                string command = Console.ReadLine();
                

                if (command=="end")
                {
                    break;
                }
                if (command == "green")
                {
                    if (cars.Count >= n)
                    {
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine($"{cars.Dequeue()} passed!");

                        }
                        count += n;
                    }
                    else
                    {
                        count += cars.Count;
                        while (cars.Count > 0)
                        {
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                        }          
                    }
                }
                else
                {
                    cars.Enqueue(command);
                }
            }
            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}
