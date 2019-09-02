namespace P04.FindEvensOrOdds
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int[] bounds = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int lowerBound = bounds[0];
            int upperBound = bounds[1];

            List<int> numbers = new List<int>();

            for (int i = lowerBound; i <= upperBound; i++)
            {
                numbers.Add(i);
            }

            string numberType = Console.ReadLine();

            Predicate<int> isEven = number => number % 2 == 0;
            Predicate<int> isOdd = number => number % 2 != 0;

            Action<List<int>> print = printNumbers =>
            {
                Console.WriteLine(string.Join(" ", printNumbers));
            };

            if (numberType == "even")
            {
                numbers = numbers.Where(n => isEven(n)).ToList();
            }
            else
            {
                numbers = numbers.Where(n => isOdd(n)).ToList();
            }

            print(numbers);

        }
    }
}
