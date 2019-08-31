namespace P02.SetsOfElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int[] sizes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int sizeFirstSet = sizes[0];
            int sizeSecondSet = sizes[1];

            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();

            for (int i = 0; i < sizeFirstSet; i++)
            {
                int currentInput = int.Parse(Console.ReadLine());
                firstSet.Add(currentInput);
            }

            for (int i = 0; i < sizeSecondSet; i++)
            {
                int currentInput = int.Parse(Console.ReadLine());
                secondSet.Add(currentInput);
            }

            foreach (var currentNumber in firstSet)
            {
                if (secondSet.Contains(currentNumber))
                {
                    Console.Write("{0} ", currentNumber);
                }
            }
            Console.WriteLine();
        }
    }
}
