using System;
using System.Collections.Generic;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> dict = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < n; i++)
            {
                string[] inputLine = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string color = inputLine[0];
                string[] clothes = inputLine[1].Split(',', StringSplitOptions.RemoveEmptyEntries);

                if (!dict.ContainsKey(color))
                {
                    dict[color] = new Dictionary<string, int>();
                }
                foreach (var item in clothes)
                {
                    if (!dict[color].ContainsKey(item))
                    {
                        dict[color][item] = new int();
                    }
                    dict[color][item]++;
                }
            }
            string[] clothingToLookFor = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string colorToLookFor = clothingToLookFor[0];
            string pieceToLookFor = clothingToLookFor[1];

            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key} clothes:");
                foreach (var kvp2 in dict[kvp.Key])
                {
                    if (colorToLookFor == kvp.Key && pieceToLookFor == kvp2.Key)
                    {
                        Console.WriteLine($"* {kvp2.Key} - {kvp2.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {kvp2.Key} - {kvp2.Value}");
                    }
                }
            }
        }
    }
}
