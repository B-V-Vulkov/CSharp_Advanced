namespace P09.ListOfPredicates
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int range = int.Parse(Console.ReadLine());
            int[] dividers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Func<int, int[], bool> isDivide = (number, dividersArray) =>
            {
                bool isdividedByDividers = true;

                foreach (var currentNumber in dividersArray)
                {
                    if (number % currentNumber != 0)
                    {
                        isdividedByDividers = false;
                        break;
                    }
                }

                return isdividedByDividers;
            };



            for (int i = 1; i <= range; i++)
            {
                if (isDivide(i, dividers))
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();



        }
    }
}
