using System;
using System.Collections.Generic;

namespace SoftuniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> VIPguests = new HashSet<string>();
            HashSet<string> guests = new HashSet<string>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "PARTY")
                {
                    break;
                }
                if (char.IsDigit(input[0]))
                {
                    VIPguests.Add(input);
                }
                else
                {
                    guests.Add(input);
                }            
            }
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }
                if (char.IsDigit(input[0]))
                {
                    VIPguests.Remove(input);
                }
                else
                {
                    guests.Remove(input);

                }
            }
            Console.WriteLine(guests.Count + VIPguests.Count);
            if (VIPguests.Count != 0)
            {
                foreach (var item in VIPguests)
                {
                    Console.WriteLine(item);
                }
            }
            if (guests.Count != 0)
            {
                foreach (var item in guests)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
