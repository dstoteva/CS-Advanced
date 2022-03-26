using System;
using System.Linq;

namespace Jagged_ArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] array = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                array[i] = input;
            }
            while (true)
            {
                string[] input = Console.ReadLine().Split();
                string command = input[0];

                if (command == "END")
                {
                    break;
                }
                int row = int.Parse(input[1]);
                int col = int.Parse(input[2]);
                int value = int.Parse(input[3]);

                if (row < 0 || col < 0 || row >= array[0].Length || col >= array[1].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }
                else
                {
                    if (command == "Add")
                    {
                        array[row][col] += value;
                    }
                    else if (command == "Subtract")
                    {
                        array[row][col] -= value;
                    }
                }
            }
            foreach (var item in array)
            {
                Console.WriteLine(string.Join(' ', item));
            }
        }
    }
}
