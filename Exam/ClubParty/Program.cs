using System;
using System.Collections.Generic;
using System.Linq;

namespace ClubParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            string[] inputLine = Console.ReadLine().Split();

            Stack<string> hallsAndPeople = new Stack<string>(inputLine);

            Dictionary<char, List<int>> hallsAndReservations = new Dictionary<char, List<int>>();

            while (hallsAndPeople.Count != 0)
            {
                string currentItem = hallsAndPeople.Pop();

                if (int.TryParse(currentItem, out int reservation))
                {
                    foreach (var item in hallsAndReservations)
                    {
                        if (item.Value.Count == 3 || item.Value.Sum() + reservation > capacity)
                        {
                            Console.WriteLine(item.Key + " -> " + string.Join(", ", item.Value));
                            hallsAndReservations.Remove(item.Key);
                            break;
                        }
                    }
                    foreach (var item in hallsAndReservations)
                    {
                        if (item.Value.Count < 3 && item.Value.Sum() + reservation <= capacity)
                        {
                            item.Value.Add(reservation);
                            break;
                        }
                    }

                }
                else if (char.TryParse(currentItem, out char hall))
                {
                    hallsAndReservations[hall] = new List<int>();
                }
            }
        }
    }
}
