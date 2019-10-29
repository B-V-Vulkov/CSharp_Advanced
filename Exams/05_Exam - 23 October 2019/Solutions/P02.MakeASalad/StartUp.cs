namespace P02.MakeASalad
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string[] inputVegetables = Console.ReadLine()
                .Split(' ');

            int[] inputCalories = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var vegetables = new Queue<string>(inputVegetables);
            var calories = new Stack<int>(inputCalories);
            var readySalads = new Queue<int>();

            int currentCalories = 0;

            while (vegetables.Count != 0 && calories.Count != 0)
            {
                int saladCalories = calories.Peek();
                string vegetable = vegetables.Dequeue();

                if (vegetable == "tomato")
                {
                    currentCalories += 80;
                }
                else if (vegetable == "carrot")
                {
                    currentCalories += 136;
                }
                else if (vegetable == "lettuce")
                {
                    currentCalories += 109;
                }
                else if (vegetable == "potato")
                {
                    currentCalories += 215;
                }

                if (currentCalories >= saladCalories)
                {
                    currentCalories = 0;
                    readySalads.Enqueue(calories.Pop());
                }
                else if (vegetables.Count == 0)
                {
                    readySalads.Enqueue(calories.Pop());
                }
            }

            Console.WriteLine(string.Join(" ", readySalads));

            if (vegetables.Count != 0)
            {
                Console.WriteLine(string.Join(" ", vegetables));
            }
            else
            {
                Console.WriteLine(string.Join(" ", calories));
            }
        }
    }
}
