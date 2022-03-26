using System;
using System.Collections.Generic;

namespace ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var shops = new SortedDictionary<string, Dictionary<string, double>>();

            while (true)
            {
                string[] line = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                if (line[0] == "Revision")
                {
                    break;
                }
                var shop = line[0];
                var product = line[1];
                double price = double.Parse(line[2]);
                if (!shops.ContainsKey(shop))
                {
                    shops[shop] = new Dictionary<string, double>();
                }
                shops[shop].Add(product, price);
            }
            foreach (var kvp in shops)
            {
                var shop = kvp.Key;
                var products = kvp.Value;

                Console.WriteLine($"{shop}->");

                foreach (var kvps in products)
                {
                    Console.WriteLine($"Product: {kvps.Key}, Price: {kvps.Value}");
                }
            }
        }
    }
}
