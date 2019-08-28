using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.FastFood
{
    class Program
    {
        static void Main()
        {
            int quantityOfFood = int.Parse(Console.ReadLine());

            int[] orders = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            Queue<int> queue = new Queue<int>(orders);

            Console.WriteLine(queue.Max());

            for (int i = 0; i < orders.Length; i++)
            {
                if (quantityOfFood >= queue.Peek())
                {
                    quantityOfFood -= queue.Dequeue();
                }
                else
                {
                    break;
                }
            }

            if (queue.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.Write("Orders left: ");
                Console.Write(string.Join(" ", queue));
                Console.WriteLine();
            }
        }
    }
}
