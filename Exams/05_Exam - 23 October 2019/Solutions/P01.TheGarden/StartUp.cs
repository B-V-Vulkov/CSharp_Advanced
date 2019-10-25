namespace P01.TheGarden
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            char[][] garden = new char[rows][];

            for (int row = 0; row < garden.Length; row++)
            {
                char[] currentRow = Console.ReadLine()
                    .Split(' ')
                    .Select(char.Parse)
                    .ToArray();

                garden[row] = new char[currentRow.Length];

                for (int col = 0; col < garden[row].Length; col++)
                {
                    garden[row][col] = currentRow[col];
                }
            }

            string input = String.Empty;
            int countHarmed = 0;

            var vegetables = new Dictionary<string, int>
            {
                { "Carrots", 0},
                { "Potatoes", 0},
                { "Lettuce", 0},
            };

            while ((input = Console.ReadLine()) != "End of Harvest")
            {
                string[] splittedInput = input.Split(' ');
                string command = splittedInput[0];
                int rowCommand = int.Parse(splittedInput[1]);
                int colCommand = int.Parse(splittedInput[2]);

                if (IsInnside(garden, rowCommand, colCommand))
                {
                    if (command == "Harvest")
                    {
                        char currentVegetable = garden[rowCommand][colCommand];
                        garden[rowCommand][colCommand] = ' ';

                        if (currentVegetable == 'L')
                        {
                            vegetables["Lettuce"]++;
                        }
                        else if (currentVegetable == 'P')
                        {
                            vegetables["Potatoes"]++;
                        }
                        else if (currentVegetable == 'C')
                        {
                            vegetables["Carrots"]++;
                        }
                    }
                    else if (command == "Mole")
                    {
                        char currentVegetable = garden[rowCommand][colCommand];
                        string direction = splittedInput[3];

                        if (garden[rowCommand][colCommand] != ' ')
                        {
                            countHarmed++;
                            garden[rowCommand][colCommand] = ' ';
                        }

                        int step = 2;

                        while (true)
                        {
                            if (direction == "up")
                            {
                                rowCommand -= step;
                            }
                            else if (direction == "down")
                            {
                                rowCommand += step;
                            }
                            else if (direction == "left")
                            {
                                colCommand -= step;
                            }
                            else if (direction == "right")
                            {
                                colCommand += step;
                            }

                            if (!IsInnside(garden, rowCommand, colCommand))
                            {
                                break;
                            }
                            else if (garden[rowCommand][colCommand] != ' ')
                            {
                                countHarmed++;
                                garden[rowCommand][colCommand] = ' ';
                            }
                        }
                    }
                }
            }

            for (int row = 0; row < garden.Length; row++)
            {
                Console.WriteLine(string.Join(" ", garden[row]));
            }

            foreach (var vegetable in vegetables)
            {
                Console.WriteLine($"{vegetable.Key}: {vegetable.Value}");
            }
            Console.WriteLine($"Harmed vegetables: {countHarmed}");
        }
        public static bool IsInnside(char[][] array, int row, int col)
        {
            return row >= 0 && col >= 0 &&
                row < array.Length &&
                col < array[row].Length;
        }
    }
}
