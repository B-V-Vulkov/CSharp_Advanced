namespace P05.AppliedArithmetics
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int[] inputNumbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string command = string.Empty;

            Func<int, int> incrementByOne = number => number += 1;
            Func<int, int> subtractByOne = number => number -= 1;
            Func<int, int> multiplyByTwo = number => number *= 2;
            Action<int[]> printNumbers = numbers =>
            {
                Console.WriteLine(string.Join(" ", numbers));
            };

            while ((command = Console.ReadLine()) != "end")
            {
                switch (command)
                {
                    case "add":
                        inputNumbers = inputNumbers.Select(incrementByOne).ToArray();
                        break;

                    case "multiply":
                        inputNumbers = inputNumbers.Select(multiplyByTwo).ToArray();
                        break;

                    case "subtract":
                        inputNumbers = inputNumbers.Select(subtractByOne).ToArray();
                        break;

                    case "print":
                        printNumbers(inputNumbers);
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
