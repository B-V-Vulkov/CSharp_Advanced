namespace P02.SeashellTreasure
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int rows = int.Parse(Console.ReadLine());

            char[][] beach = new char[rows][];

            for (int row = 0; row < rows; row++)
            {
                char[] line = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                beach[row] = new char[line.Length];

                for (int col = 0; col < line.Length; col++)
                {
                    beach[row][col] = line[col];
                }
            }

            string input = string.Empty;

            List<char> collectedSeashells = new List<char>();
            List<char> stolenSeashells = new List<char>();

            while ((input = Console.ReadLine()) != "Sunset")
            {
                string[] splittedInput = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = splittedInput[0];
                int row = int.Parse(splittedInput[1]);
                int col = int.Parse(splittedInput[2]);

                if (IsInside(beach, row, col))
                {
                    if (command == "Collect" && beach[row][col] != '-')
                    {
                        collectedSeashells.Add(beach[row][col]);
                        beach[row][col] = '-';
                    }
                    else if (command == "Steal")
                    {
                        string direction = splittedInput[3];

                        for (int i = 0; i <= 3; i++)
                        {
                            int currentRow = row;
                            int currentCol = col;

                            if (direction == "up")
                            {
                                currentRow -= i;
                            }
                            else if (direction == "right")
                            {
                                currentCol += i;
                            }
                            else if (direction == "down")
                            {
                                currentRow += i;
                            }
                            else if (direction == "left")
                            {
                                currentCol -= i;
                            }

                            if (IsInside(beach, currentRow, currentCol) && 
                                beach[currentRow][currentCol] != '-')
                            {
                                stolenSeashells.Add(beach[currentRow][currentCol]);
                                beach[currentRow][currentCol] = '-';
                            }
                        }
                    }
                }
            }

            for (int row = 0; row < beach.Length; row++)
            {
                for (int col = 0; col < beach[row].Length; col++)
                {
                    Console.Write($"{beach[row][col]} ");
                }
                Console.WriteLine();
            }

            Console.Write($"Collected seashells: {collectedSeashells.Count}");

            if (collectedSeashells.Count != 0)
            {
                Console.WriteLine(" -> " + string.Join(", ", collectedSeashells));
            }
            else
            {
                Console.WriteLine();
            }

            Console.WriteLine($"Stolen seashells: {stolenSeashells.Count}");

        }
        public static bool IsInside(char[][] array, int row, int col)
        {
            return row >= 0 && col >= 0 &&
                row < array.Length &&
                col < array[row].Length;
        }
    }
}
