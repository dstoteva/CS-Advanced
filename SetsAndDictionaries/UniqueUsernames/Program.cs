using System;
using System.Collections.Generic;

namespace UniqueUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> users = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                string user = Console.ReadLine();
                users.Add(user);
            }
            foreach (var item in users)
            {
                Console.WriteLine(item);
            }
        }
    }
}
