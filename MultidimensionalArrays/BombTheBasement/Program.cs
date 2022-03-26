using System;
using System.Linq;

namespace BombTheBasement
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int rows = int.Parse(input[0]);
            int cols = int.Parse(input[1]);

            string[] input2 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int targetRow = int.Parse(input2[0]);
            int targetCol = int.Parse(input2[1]);
            int radius = int.Parse(input2[2]);

            int[,] matrix = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = 0;
                }
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    double distance = Math.Sqrt(Math.Pow(i - targetRow, 2) + Math.Pow(j - targetCol, 2));

                    if (distance <= radius)
                    {
                        matrix[i, j] = 1;
                    }
                }
            }
            int[][] resultMatrix = new int[cols][];
            for (int row = 0; row < cols; row++)
            {
                resultMatrix[row] = new int[rows];
                for (int col = 0; col < rows; col++)
                {
                    resultMatrix[row][col] = matrix[col, row];
                }
                resultMatrix[row] = resultMatrix[row].OrderByDescending(x => x).ToArray();
            }
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = resultMatrix[col][row];
                }
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
