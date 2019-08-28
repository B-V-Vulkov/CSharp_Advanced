using System;
using System.Collections.Generic;
using System.Linq;

namespace P02BasicQueueOperations
{
    class Program
    {
        static void Main()
        {
            var splittedInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int addNumber = splittedInput[0];
            int removeNumber = splittedInput[1];
            int searchNumber = splittedInput[2];

            var numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var queue = new Queue<int>(numbers);

            for (int i = 0; i < removeNumber; i++)
            {
                queue.Dequeue();
            }

            if (queue.Contains(searchNumber))
            {
                Console.WriteLine("true");
            }
            else if (queue.Count == 0)
            {
                Console.WriteLine(queue.FirstOrDefault());
            }
            else
            {
                int minValue = int.MaxValue;

                while (queue.Count != 0)
                {
                    if (queue.Peek() < minValue)
                    {
                        minValue = queue.Peek();
                    }
                    queue.Dequeue();
                }
                Console.WriteLine(minValue);
            }

        }
    }
}
