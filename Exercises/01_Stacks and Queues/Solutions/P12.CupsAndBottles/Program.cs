using System;
using System.Collections.Generic;
using System.Linq;

namespace P12.CupsAndBottles
{
    class Program
    {
        static void Main()
        {
            Queue<int> cups = new Queue<int>(ToIntArray(Console.ReadLine()));
            Stack<int> bottles = new Stack<int>(ToIntArray(Console.ReadLine()));

            int currentCup = 0;
            int currentBottles = 0;
            int wastedWater = 0;

            while (cups.Count != 0 && bottles.Count != 0)
            {
                currentCup = cups.Peek();
                currentBottles += bottles.Pop();

                if (currentBottles - currentCup >= 0)
                {
                    wastedWater += (currentBottles - currentCup);
                    cups.Dequeue();
                    currentBottles = 0;
                }
            }

            if (bottles.Count != 0)
            {
                Console.Write("Bottles: ");
                Console.WriteLine(string.Join(" ", bottles));
            }
            else if (cups.Count != 0)
            {
                Console.Write("Cups: ");
                Console.WriteLine(string.Join(" ", cups));
            }

            Console.WriteLine("Wasted litters of water: {0}", wastedWater);
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
