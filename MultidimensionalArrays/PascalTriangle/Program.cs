using System;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[][] triangle = new long[n][];

            triangle[0] = new long[1] {1};
            
            for (int i = 1; i < n; i++)
            {
                triangle[i] = new long[i + 1];
                triangle[i][triangle[i].Length - 1] = 1;
                triangle[i][0] = 1;
                for (int j = 1; j < triangle[i].Length - 1; j++)
                {
                    triangle[i][j] = triangle[i - 1][j] + triangle[i - 1][j - 1];
                }
            }
            foreach (var item in triangle)
            {
                Console.WriteLine(string.Join(' ', item));
            }
        }
    }
}
