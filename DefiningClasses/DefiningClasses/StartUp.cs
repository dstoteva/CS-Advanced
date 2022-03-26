using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var family = new Family();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var person = new Person(input[0], int.Parse(input[1]));
                family.AddMember(person);
            }
            var over30 = family.GetPeopleOver30().OrderBy(x => x.Name);
            Console.WriteLine(string.Join(Environment.NewLine, over30));
        }
    }
}
