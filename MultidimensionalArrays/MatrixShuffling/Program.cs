using System;
using System.Linq;

namespace MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];

            string[,] matrix = new string[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                string[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = line[j];
                }
            }
            while (true)
            {
                string[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string command = line[0];
                if (command == "END")
                {
                    break;
                }
                if (command != "swap" && line.Length != 5)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                int row1 = 0;
                int row2 = 0;
                int col1 = 0;
                int col2 = 0;
                bool boolIsIntrow1 = int.TryParse(line[1], out row1);
                bool boolIsIntrow2 = int.TryParse(line[2], out row2);
                bool boolIsIntcol1 = int.TryParse(line[3], out col1);
                bool boolIsIntcol2 = int.TryParse(line[4], out col2);

                if (!boolIsIntcol1 || !boolIsIntcol2 || !boolIsIntrow1 || !boolIsIntrow2)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                if (row1 < 0 || row2 < 0 || col1 < 0 || col2 < 0 || row1 > rows - 1 || row2 > cols - 1 || col1 > rows || col2 > cols)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                else
                {
                    string matrixToSwitch = matrix[row1, row2];
                    matrix[row1, row2] = matrix[col1, col2];
                    matrix[col1, col2] = matrixToSwitch;
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            Console.Write(matrix[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
