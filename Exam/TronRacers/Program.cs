using System;
using System.Linq;

namespace TronRacers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[][] matrix = new char[n][];

            for (int i = 0; i < n; i++)
            {
                matrix[i] = Console.ReadLine().ToCharArray();
            }

            int rowIndexOfF = -1;
            int colIndexOfF = -1;
            int rowIndexOfS = -1;
            int colIndexOfS = -1;
            for (int i = 0; i < n; i++)
            {
                if (matrix[i].Contains('s'))
                {
                    rowIndexOfS = i;
                    colIndexOfS = Array.IndexOf(matrix[i], 's');
                }
                else if (matrix[i].Contains('f'))
                {
                    rowIndexOfF = i;
                    colIndexOfF = Array.IndexOf(matrix[i], 'f');
                }
            }

            while (true)
            {
                string[] moves = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string firstMove = moves[0];
                string secondMove = moves[1];

                switch (firstMove)
                {
                    case "down":
                        if (rowIndexOfF == n - 1)
                        {
                            rowIndexOfF = 0;
                        }
                        else
                        {
                            rowIndexOfF++;
                        }
                        break;
                    case "up":
                        if (rowIndexOfF == 0)
                        {
                            rowIndexOfF = n - 1;
                        }
                        else
                        {
                            rowIndexOfF--;
                        }
                        break;
                    case "left":
                        if (colIndexOfF == 0)
                        {
                            colIndexOfF = n - 1;
                        }
                        else
                        {
                            colIndexOfF--;
                        }
                        break;
                    case "right":
                        if (colIndexOfF == n - 1)
                        {
                            colIndexOfF = 0;
                        }
                        else
                        {
                            colIndexOfF++;
                        }
                        break;
                    default:
                        break;
                }

                if (matrix[rowIndexOfF][colIndexOfF] != 's')
                {
                    matrix[rowIndexOfF][colIndexOfF] = 'f';
                }
                else
                {
                    matrix[rowIndexOfF][colIndexOfF] = 'x';
                    break;
                }

                switch (secondMove)
                {
                    case "down":
                        if (rowIndexOfS == n - 1)
                        {
                            rowIndexOfS = 0;
                        }
                        else
                        {
                            rowIndexOfS++;
                        }
                        break;
                    case "up":
                        if (rowIndexOfS == 0)
                        {
                            rowIndexOfS = n - 1;
                        }
                        else
                        {
                            rowIndexOfS--;
                        }
                        break;
                    case "left":
                        if (colIndexOfS == 0)
                        {
                            colIndexOfS = n - 1;
                        }
                        else
                        {
                            colIndexOfS--;
                        }
                        break;
                    case "right":
                        if (colIndexOfS == n - 1)
                        {
                            colIndexOfS = 0;
                        }
                        else
                        {
                            colIndexOfS++;
                        }
                        break;
                    default:
                        break;
                }

                if (matrix[rowIndexOfS][colIndexOfS] != 'f')
                {
                    matrix[rowIndexOfS][colIndexOfS] = 's';
                }
                else
                {
                    matrix[rowIndexOfS][colIndexOfS] = 'x';
                    break;
                }
            }
            foreach (var line in matrix)
            {
                Console.WriteLine(line);
            }
        }
    }
}
