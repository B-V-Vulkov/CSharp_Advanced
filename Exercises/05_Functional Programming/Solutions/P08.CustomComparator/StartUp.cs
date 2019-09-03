namespace P08.CustomComparator
{
    using System;
    using System.Linq;
    using System.Collections;

    public class StartUp
    {
        public static void Main()
        {
            int[] inputNumbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Array.Sort(inputNumbers);

            Predicate<int> isEven = number => number % 2 == 0;
            Predicate<int> isOdd = number => number % 2 != 0;

            Console.Write(string.Join(" ", inputNumbers.Where(n => isEven(n))) + " ");
            Console.WriteLine(string.Join(" ", inputNumbers.Where(n => isOdd(n))));
        }
    }
}
