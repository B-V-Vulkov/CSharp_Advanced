namespace P06.ReverseAndExclude
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int[] inputNumbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int divisibleNumber = int.Parse(Console.ReadLine());

            Predicate<int> isNotDivisible = number => number % divisibleNumber != 0;

            inputNumbers = inputNumbers
                .Where(n => isNotDivisible(n))
                .ToArray();

            inputNumbers = inputNumbers.Reverse().ToArray();

            Console.WriteLine(string.Join(" ", inputNumbers));
        }
    }
}
