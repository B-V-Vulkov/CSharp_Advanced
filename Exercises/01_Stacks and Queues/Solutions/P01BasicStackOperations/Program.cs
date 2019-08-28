using System;
using System.Collections.Generic;
using System.Linq;

namespace P01BasicStackOperations
{
    class Program
    {
        static void Main()
        {
            var splittedInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var stack = new Stack<int>();

            int numbersPush = int.Parse(splittedInput[0]);
            int numbersPop = int.Parse(splittedInput[1]);
            int searchNumber = int.Parse(splittedInput[2]);

            for (int i = 0; i < numbersPush; i++)
            {
                stack.Push(numbers[i]);
            }

            for (int i = 0; i < numbersPop; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(searchNumber))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count == 0)
            {
                Console.WriteLine(stack.FirstOrDefault());
            }
            else
            {
                int minValue = int.MaxValue;
                while (stack.Count != 0)
                {
                    if (stack.Peek() < minValue)
                    {
                        minValue = stack.Peek();
                    }
                    stack.Pop();
                }
                Console.WriteLine(minValue);
            }
        }
    }
}
