using System;
using System.Collections.Generic;
using System.Linq;

namespace AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, List<double>>();

            int totalMax = int.Parse(Console.ReadLine());

            for (int i = 0; i < totalMax; i++)
            {
                var markParts = Console.ReadLine().Split();
                var name = markParts[0];
                double grade = double.Parse(markParts[1]);

                if (!dict.ContainsKey(name))
                {
                    dict[name] = new List<double>();

                }
                dict[name].Add(grade);
            }
            foreach (var kvp in dict)
            {
                var name = kvp.Key;
                var marks = kvp.Value;
                var average = marks.Average();

                Console.Write($"{name} -> ");
                foreach (var item in marks)
                {
                    Console.Write($"{item:f2} ");
                }
                Console.WriteLine($"(avg: {average:f2})");
            }
        }
    }
}
