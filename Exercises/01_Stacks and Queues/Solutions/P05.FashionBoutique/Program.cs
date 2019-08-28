using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.FashionBoutique
{
    class Program
    {
        static void Main()
        {
            int[] splittedInput = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            Stack<int> clothes = new Stack<int>(splittedInput);

            int capacity = int.Parse(Console.ReadLine());
            int numberOfRacks = 1;
            int currentCapacity = 0;

            while (clothes.Count != 0)
            {
                if (clothes.Peek() + currentCapacity <= capacity)
                {
                    currentCapacity += clothes.Peek();
                }
                else
                {
                    currentCapacity = clothes.Peek();
                    numberOfRacks++;
                }
                clothes.Pop();
            }

            Console.WriteLine(numberOfRacks);
        }
    }
}
