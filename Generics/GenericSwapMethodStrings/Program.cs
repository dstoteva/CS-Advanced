using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwapMethodStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            var boxOfString = new Box<double>();

            for (int i = 0; i < count; i++)
            {
                double line = double.Parse(Console.ReadLine());       
                boxOfString.Add(line);
            }
            // int[] indexes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            // int firstIndex = indexes[0];
            // int secondIndex = indexes[1];
            // Swap(boxOfString.Data, firstIndex, secondIndex);
            //Console.WriteLine(boxOfString);

            double comparer = double.Parse(Console.ReadLine());
            int counter = GetCountOfGreater(boxOfString.Data, comparer);

            Console.WriteLine(counter);
        }
        public static int GetCountOfGreater<T>(List<T> list, T item) where T : IComparable

        {
            int count = 0;
            foreach (var i in list)
            {
                if (i.CompareTo(item) > 0)
                {
                    count++;
                }
            }
            return count;
        }

        static void Swap<T>(List<T> listData, int firstIndex, int secondIndex)
        {
            var temp = listData[firstIndex];
            listData[firstIndex] = listData[secondIndex];
            listData[secondIndex] = temp;
        }
    }
}
