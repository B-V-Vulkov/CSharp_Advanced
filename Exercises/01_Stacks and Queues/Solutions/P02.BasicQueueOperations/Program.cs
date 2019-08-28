using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.BasicQueueOperations
{
    class Program
    {
        static void Main()
        {
            int[] commands = ToIntArray(Console.ReadLine());
            int addElements = commands[0];
            int removeElements = commands[1];
            int searchElement = commands[2];

            int[] input = ToIntArray(Console.ReadLine());

            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < addElements; i++)
            {
                queue.Enqueue(input[i]);
            }

            for (int i = 0; i < removeElements; i++)
            {
                queue.Dequeue();
            }

            bool isNotFound = true;
            int smallestElement = int.MaxValue;

            foreach (var element in queue)
            {
                if (element == searchElement)
                {
                    Console.WriteLine("true");
                    isNotFound = false;
                    break;
                }
                else
                {
                    if (element < smallestElement)
                    {
                        smallestElement = element;
                    }
                }
            }

            if (queue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (isNotFound)
            {
                Console.WriteLine(smallestElement);
            }
        }

        private static int[] ToIntArray(string input)
        {
            int[] result = input.Split(" ").Select(int.Parse).ToArray();
            return result;
        }
    }
}
