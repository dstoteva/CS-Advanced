using System;
using System.Collections.Generic;
using System.Linq;

namespace AutoRepairAndService
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Queue<string> waiting = new Queue<string>(input);
            Stack<string> served = new Stack<string>();
            while (true)
            {
                string[] command = Console.ReadLine().Split('-');
                if (command[0] == "End")
                {
                    break;
                }
                switch (command[0])
                {
                    case "Service":
                        if (waiting.Any())
                        {
                            string current = waiting.Dequeue();
                            Console.WriteLine($"Vehicle {current} got served.");
                            served.Push(current);
                        }                 
                        break;
                    case "CarInfo":
                        if (waiting.Contains(command[1]))
                        {
                            Console.WriteLine("Still waiting for service.");
                        }
                        else
                        {
                            Console.WriteLine("Served.");
                        }
                        break;
                    case "History":
                        Console.WriteLine(string.Join(", ", served));
                        break;
                }
            }
            if (waiting.Any())
            {
                Console.WriteLine($"Vehicles for service: {string.Join(", ", waiting)}");
            }
            Console.WriteLine($"Served vehicles: {string.Join(", ", served)}");
        }
    }
}
