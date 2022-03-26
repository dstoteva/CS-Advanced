using System;
using System.Linq;

namespace Sneaking
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
            char[] commands = Console.ReadLine().ToCharArray();

            for (int d = 0; d < commands.Length; d++)
            {
                for (int row = 0; row < n; row++)
                {
                    if (matrix[row].Contains('b'))
                    {
                        int lenght = matrix[row].Length;
                        int indexOfB = Array.IndexOf(matrix[row], 'b');
                        if (indexOfB < lenght - 1)
                        {
                            matrix[row][indexOfB] = '.';
                            matrix[row][indexOfB + 1] = 'b';
                        }
                        else
                        {
                            matrix[row][indexOfB] = 'd';
                        }
                    }
                    else if (matrix[row].Contains('d'))
                    {
                        int indexOfD = Array.IndexOf(matrix[row], 'd');

                        if (indexOfD > 0)
                        {
                            matrix[row][indexOfD] = '.';
                            matrix[row][indexOfD - 1] = 'd';
                        }
                        else
                        {
                            matrix[row][indexOfD] = 'b';
                        }
                    }
                }

                bool someoneIsDead = false;
                for (int row = 0; row < n; row++)
                {
                    if (matrix[row].Contains('S') && matrix[row].Contains('b'))
                    {
                        int indexOfSam = Array.IndexOf(matrix[row], 'S');
                        int indexOfB = Array.IndexOf(matrix[row], 'b');
                        if (indexOfSam > indexOfB)
                        {
                            Console.WriteLine($"Sam died at {row}, {indexOfSam}");
                            matrix[row][indexOfSam] = 'X';
                            someoneIsDead = true;
                            break;
                        }
                    }
                    else if (matrix[row].Contains('S') && matrix[row].Contains('d'))
                    {
                        int indexOfSam = Array.IndexOf(matrix[row], 'S');
                        int indexOfD = Array.IndexOf(matrix[row], 'd');
                        if (indexOfSam < indexOfD)
                        {
                            Console.WriteLine($"Sam died at {row}, {indexOfSam}");
                            matrix[row][indexOfSam] = 'X';
                            someoneIsDead = true;
                            break;
                        }
                    }
                    if (someoneIsDead)
                    {
                        break;
                    }
                }
                if (someoneIsDead)
                {
                    break;
                }

                char direction = commands[d];
                for (int row = 0; row < n; row++)
                {
                    bool foundSam = false;
                    if (matrix[row].Contains('S'))
                    {
                        foundSam = true;
                        int indexOfSam = Array.IndexOf(matrix[row], 'S');

                        switch (direction)
                        {
                            case 'U':
                                matrix[row][indexOfSam] = '.';
                                matrix[row - 1][indexOfSam] = 'S';
                                break;
                            case 'D':
                                matrix[row][indexOfSam] = '.';
                                matrix[row + 1][indexOfSam] = 'S';
                                break;
                            case 'L':
                                matrix[row][indexOfSam] = '.';
                                matrix[row][indexOfSam - 1] = 'S';
                                break;
                            case 'R':
                                matrix[row][indexOfSam] = '.';
                                matrix[row][indexOfSam + 1] = 'S';
                                break;
                            case 'W':
                                break;
                        }
                    }
                    if (foundSam)
                    {
                        break;
                    }
                }
                for (int row = 0; row < n; row++)
                {
                    if (matrix[row].Contains('S') && matrix[row].Contains('N'))
                    {
                        int indexOfNik = Array.IndexOf(matrix[row], 'N');
                        Console.WriteLine("Nikoladze killed!");
                        matrix[row][indexOfNik] = 'X';
                        someoneIsDead = true;
                        break;
                    }
                }
                if (someoneIsDead)
                {
                    break;
                }
            }
            foreach (var item in matrix)
            {
                Console.WriteLine(item);
            }
        }
    }
}

