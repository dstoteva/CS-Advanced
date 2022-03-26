using System;
using System.Collections.Generic;
using System.Linq;

namespace SumMatrixElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int row = n[0];
            int column = n[1];

            int[,] matrix = new int[row, column];
            int sum = 0;

            for (int i = 0; i < row; i++)
            {
                Queue<int> queue = new Queue<int>(Console.ReadLine().Split(", ").Select(int.Parse).ToArray());
                for (int j = 0; j < column; j++)
                {
                    matrix[i, j] = queue.Dequeue();
                    sum += matrix[i, j];
                }
            }
            Console.WriteLine(row);
            Console.WriteLine(column);
            Console.WriteLine(sum);
        }
    }
}
