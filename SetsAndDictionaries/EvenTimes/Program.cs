using System;
using System.Collections.Generic;

namespace EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 0;
            HashSet<int> allNums = new HashSet<int>();
            for (int i = 0; i < n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                if (allNums.Contains(currentNum))
                {
                    allNums.Remove(currentNum);
                    num = currentNum;
                }
                else
                {
                    allNums.Add(currentNum);
                }  
            }
            Console.WriteLine(num);
        }
    }
}
