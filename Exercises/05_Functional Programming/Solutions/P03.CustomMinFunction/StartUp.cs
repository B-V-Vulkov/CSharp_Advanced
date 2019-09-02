namespace P03.CustomMinFunction
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            Func<int[], int> smallestNumber = numbers =>
            {
                int minValue = int.MaxValue;

                foreach (var number in numbers)
                {
                    if (number < minValue)
                    {
                        minValue = number;
                    }
                }

                return minValue;
            };

            int[] inputNumbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(smallestNumber(inputNumbers));

        }
    }
}
