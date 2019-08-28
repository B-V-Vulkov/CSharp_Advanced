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


            if (queue.Contains(searchElement))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (queue.Count != 0)
                {
                    Console.WriteLine(queue.Min());
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
        }

        private static int[] ToIntArray(string input)
        {
            int[] result = input.Split(" ").Select(int.Parse).ToArray();
            return result;
        }
    }
}
