using System;
using System.Collections.Generic;
using System.Linq;

namespace P04FastFood
{
    class Program
    {
        static void Main()
        {
            int quantityOfTheFood = int.Parse(Console.ReadLine());
            var orders = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var queue = new Queue<int>(orders);
            Console.WriteLine(queue.Max());

            while (queue.Count != 0)
            {
                int currentOrder = queue.Peek();

                if ((quantityOfTheFood - currentOrder) >= 0)
                {
                    quantityOfTheFood -= currentOrder;
                }
                else
                {
                    int[] leftOrders = queue.ToArray();
                    Console.Write("Orders left: ");
                    Console.WriteLine(string.Join(" ", leftOrders));
                    return;
                }
                queue.Dequeue();
            }

            Console.WriteLine("Orders complete");
        }
    }
}
