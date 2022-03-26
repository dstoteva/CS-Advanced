using System;
using System.Linq;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];

            int primarySum = 0;
            int secondarySum = 0;
            for (int i = 0; i < size; i++)
            {
                int[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = line[j];
                    if (i == j)
                    {
                        primarySum += matrix[j, i];
                    }
                    if (j == size - i - 1)
                    {
                        secondarySum += matrix[i, j];
                    }
                }
            }
            Console.WriteLine(Math.Abs(primarySum - secondarySum));
        }
    }
}
