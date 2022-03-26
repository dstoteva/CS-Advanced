using System;

namespace GenericBoxOfSting
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int linesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < linesCount; i++)
            {
                int content = int.Parse(Console.ReadLine());
                Box<int> boxString = new Box<int>(content);
                Console.WriteLine(boxString);
            }
        }
    }
}
