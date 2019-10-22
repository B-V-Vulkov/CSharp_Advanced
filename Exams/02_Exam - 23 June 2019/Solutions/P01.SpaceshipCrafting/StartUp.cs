namespace P01.SpaceshipCrafting
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var liquidsInput = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var itemsInput = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var liquids = new Queue<int>(liquidsInput);
            var items = new Stack<int>(itemsInput);

            var advancedMaterial = new SortedDictionary<string, int>
            {
                { "Glass", 0},
                { "Aluminium", 0},
                { "Lithium", 0},
                { "Carbon fiber", 0},
            };

            while (liquids.Count != 0 && items.Count != 0)
            {
                int sum = liquids.Peek() + items.Peek();

                if (sum == 25)
                {
                    advancedMaterial["Glass"] += 1;
                }
                else if (sum == 50)
                {
                    advancedMaterial["Aluminium"] += 1;
                }
                else if (sum == 75)
                {
                    advancedMaterial["Lithium"] += 1;
                }
                else if (sum == 100)
                {
                    advancedMaterial["Carbon fiber"] += 1;
                }

                else
                {
                    liquids.Dequeue();

                    int currentItem = items.Pop() + 3;
                    items.Push(currentItem);
                    continue;
                }

                liquids.Dequeue();
                items.Pop();
            }

            bool isBuild = true;

            foreach (var item in advancedMaterial)
            {
                if (item.Value == 0)
                {
                    isBuild = false;
                    break;
                }
            }

            if (isBuild)
            {
                Console.WriteLine("Wohoo! You succeeded in building the spaceship!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to build the spaceship.");
            }

            Console.Write("Liquids left: ");

            if (liquids.Count == 0)
            {
                Console.WriteLine("none");
            }
            else
            {
                Console.WriteLine(string.Join(", ", liquids));
            }

            Console.Write("Physical items left: ");

            if (items.Count == 0)
            {
                Console.WriteLine("none");
            }
            else
            {
                Console.WriteLine(string.Join(", ", items));
            }

            foreach (var item in advancedMaterial)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}