using System;
using System.Collections.Generic;

namespace P03MaximumAndMinimumElement
{
    class Program
    {
        static void Main()
        {
            int numberQueries = int.Parse(Console.ReadLine());

            var numbers = new Stack<int>();
            var currentNumbers = new Queue<int>();

            for (int i = 1; i <= numberQueries; i++)
            {
                string input = Console.ReadLine();
                var splittedInput = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = splittedInput[0];

                switch (command)
                {
                    case "1":
                        int addNumber = int.Parse(splittedInput[1]);
                        numbers.Push(addNumber);
                        break;

                    case "2":
                        if (numbers.Count != 0)
                        {
                            numbers.Pop();

                        }
                        break;

                    case "3":
                        currentNumbers = new Queue<int>(numbers);
                        int maxValue = int.MinValue;

                        if (numbers.Count == 0)
                        {
                            break;
                        }

                        while (currentNumbers.Count != 0)
                        {
                            if (currentNumbers.Peek() > maxValue)
                            {
                                maxValue = currentNumbers.Peek();
                            }
                            currentNumbers.Dequeue();
                        }
                        Console.WriteLine(maxValue);
                        break;

                    case "4":
                        currentNumbers = new Queue<int>(numbers);
                        int minValue = int.MaxValue;

                        if (numbers.Count == 0)
                        {
                            break;
                        }

                        while (currentNumbers.Count != 0)
                        {
                            if (currentNumbers.Peek() < minValue)
                            {
                                minValue = currentNumbers.Peek();
                            }
                            currentNumbers.Dequeue();
                        }
                        Console.WriteLine(minValue);
                        break;

                    default:
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", numbers));

        }
    }
}
