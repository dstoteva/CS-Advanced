using System;
using System.Collections.Generic;
using System.Linq;

namespace KeyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int price = int.Parse(Console.ReadLine());
            int size = int.Parse(Console.ReadLine());
            int[] bullets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] locks = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int intelligenceValue = int.Parse(Console.ReadLine());

            Queue<int> allLocks = new Queue<int>(locks);
            Stack<int> allBullets = new Stack<int>(bullets);

            int currentBulletsIn = size;

            while (true)
            {
                if (allLocks.Count == 0)
                {
                    Console.WriteLine($"{allBullets.Count} bullets left. Earned ${intelligenceValue}");
                    return;
                }
                if (allBullets.Count == 0)
                {
                    Console.WriteLine($"Couldn't get through. Locks left: {allLocks.Count}");
                    return;
                }
                int currentBullet = allBullets.Pop();
                int currentLock = allLocks.Peek();
                intelligenceValue -= price;
                currentBulletsIn--;
                if (currentBullet <= currentLock)
                {
                    allLocks.Dequeue();
                    Console.WriteLine("Bang!");
                }
                else
                {
                    Console.WriteLine("Ping!");
                }
                if (currentBulletsIn == 0 && allBullets.Any())
                {
                    Console.WriteLine("Reloading!");
                    currentBulletsIn = size;
                }
            }

        }
    }
}
