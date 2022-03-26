using System;
using System.Linq;

namespace ExcelFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] headerRow = Console.ReadLine().Split(", ");
            string[][] matrix = new string[n - 1][];
            for (int i = 0; i < n - 1; i++)
            {
                matrix[i] = Console.ReadLine().Split(", ");
            }

            string[] inputLine = Console.ReadLine().Split();
            string command = inputLine[0];
            string header = inputLine[1];

            int index = Array.IndexOf(headerRow, header);

            switch (command)
            {
                case "hide":
                    Console.WriteLine(string.Join(" | ", headerRow.Where((x, i) => i != index)));
                    for (int i = 0; i < n - 1; i++)
                    {
                        Console.WriteLine(string.Join(" | ", matrix[i].Where((x, j) => j != index)));
                    }
                    break;
                case "sort":
                    Console.WriteLine(string.Join(" | ", headerRow));
                    matrix = matrix.OrderBy(x => x[index]).ToArray();
                    for (int i = 0; i < n - 1; i++)
                    {
                        Console.WriteLine(string.Join(" | ", matrix[i]));
                    }
                    break;
                case "filter":
                    string value = inputLine[2];
                    Console.WriteLine(string.Join(" | ", headerRow));
                    matrix = matrix.Where(x => x[index] == value).ToArray();
                    for (int i = 0; i < matrix.Length; i++)
                    {
                        Console.WriteLine(string.Join(" | ", matrix[i]));
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
