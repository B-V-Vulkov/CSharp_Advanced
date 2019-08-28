using System;
using System.Collections.Generic;
using System.Linq;

namespace P05FashionBoutique
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int capacity = int.Parse(Console.ReadLine());
            var clothes = new Stack<int>(input);
            int count = 1;
            int sum = 0;

            while (clothes.Count != 0)
            {
                int current = clothes.Pop();

                if (capacity >= (sum + current))
                {
                    sum += current;
                }
                else
                {
                    sum = current;
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
