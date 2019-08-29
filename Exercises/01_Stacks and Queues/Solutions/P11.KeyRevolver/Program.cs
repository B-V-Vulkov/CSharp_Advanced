using System;
using System.Collections.Generic;
using System.Linq;

namespace P11.KeyRevolver
{
    class Program
    {
        static void Main()
        {
            int priceOfBullet = int.Parse(Console.ReadLine());
            int sizeOfGunBarrel = int.Parse(Console.ReadLine());
            Stack<int> bullets = new Stack<int>(ToIntArray(Console.ReadLine()));
            Queue<int> locks = new Queue<int>(ToIntArray(Console.ReadLine()));
            int intelligence = int.Parse(Console.ReadLine());

            int countOfBullets = 0;
            int currentCountOfBullets = 0;

            while (bullets.Count != 0 && locks.Count != 0)
            {
                countOfBullets++;
                currentCountOfBullets++;

                int currentBullets = bullets.Pop();
                int currentLocks = locks.Peek();

                if (currentBullets <= currentLocks)
                {
                    locks.Dequeue();
                    Console.WriteLine("Bang!");
                }
                else
                {
                    Console.WriteLine("Ping!");
                }

                if (currentCountOfBullets == sizeOfGunBarrel && bullets.Count != 0)
                {
                    currentCountOfBullets = 0;
                    Console.WriteLine("Reloading!");
                }
            }

            if (locks.Count != 0)
            {
                Console.WriteLine("Couldn't get through. Locks left: {0}", locks.Count);
            }
            else
            {
                int earned = intelligence - countOfBullets * priceOfBullet;
                Console.WriteLine("{0} bullets left. Earned ${1}", bullets.Count, earned);
            }
        }

        private static int[] ToIntArray(string input)
        {
            int[] result = input
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            return result;
        }
    }
}
