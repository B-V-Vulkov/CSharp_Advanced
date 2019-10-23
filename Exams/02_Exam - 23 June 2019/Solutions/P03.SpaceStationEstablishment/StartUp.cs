namespace P03.SpaceStationEstablishment
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];

            int row = 0;
            int col = 0;

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                string currentRow = Console.ReadLine();

                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    char currentChar = currentRow[c];

                    matrix[r, c] = currentChar;

                    if (currentChar == 'S')
                    {
                        row = r;
                        col = c;
                    }
                }
            }

            int starPower = 0;
            bool isNotInnside = false;

            while (!isNotInnside && starPower < 50)
            {
                string command = Console.ReadLine();

                matrix[row, col] = '-';

                if (command == "up")
                {
                    row -= 1;

                    if (IsInnside(matrix, row, col))
                    {
                        char currentSymbol = matrix[row, col];

                        if (char.IsDigit(currentSymbol))
                        {
                            starPower += int.Parse(currentSymbol.ToString());
                            matrix[row, col] = 'S';
                        }
                        else if (currentSymbol == 'O')
                        {
                            matrix[row, col] = '-';
                            int[] newPosition = FindBlackHoles(matrix);
                            row = newPosition[0];
                            col = newPosition[1];
                            matrix[row, col] = 'S';
                        }
                    }
                    else
                    {
                        isNotInnside = true;
                    }
                }

                else if (command == "down")
                {
                    row += 1;

                    if (IsInnside(matrix, row, col))
                    {
                        char currentSymbol = matrix[row, col];

                        if (char.IsDigit(currentSymbol))
                        {
                            starPower += int.Parse(currentSymbol.ToString());
                            matrix[row, col] = 'S';
                        }
                        else if (currentSymbol == 'O')
                        {
                            matrix[row, col] = '-';
                            int[] newPosition = FindBlackHoles(matrix);
                            row = newPosition[0];
                            col = newPosition[1];
                            matrix[row, col] = 'S';
                        }
                    }
                    else
                    {
                        isNotInnside = true;
                    }
                }

                else if (command == "left")
                {
                    col -= 1;

                    if (IsInnside(matrix, row, col))
                    {
                        char currentSymbol = matrix[row, col];

                        if (char.IsDigit(currentSymbol))
                        {
                            starPower += int.Parse(currentSymbol.ToString());
                            matrix[row, col] = 'S';
                        }
                        else if (currentSymbol == 'O')
                        {
                            matrix[row, col] = '-';
                            int[] newPosition = FindBlackHoles(matrix);
                            row = newPosition[0];
                            col = newPosition[1];
                            matrix[row, col] = 'S';
                        }
                    }
                    else
                    {
                        isNotInnside = true;
                    }
                }

                else if (command == "right")
                {
                    col += 1;

                    if (IsInnside(matrix, row, col))
                    {
                        char currentSymbol = matrix[row, col];

                        if (char.IsDigit(currentSymbol))
                        {
                            starPower += int.Parse(currentSymbol.ToString());
                            matrix[row, col] = 'S';
                        }
                        else if (currentSymbol == 'O')
                        {
                            matrix[row, col] = '-';
                            int[] newPosition = FindBlackHoles(matrix);
                            row = newPosition[0];
                            col = newPosition[1];
                            matrix[row, col] = 'S';
                        }
                    }
                    else
                    {
                        isNotInnside = true;
                    }
                }
            }

            if (isNotInnside)
            {
                Console.WriteLine("Bad news, the spaceship went to the void.");
            }
            else
            {
                Console.WriteLine("Good news! Stephen succeeded in collecting enough star power!");
            }

            Console.WriteLine($"Star power collected: {starPower}");

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    Console.Write(matrix[r, c]);
                }
                Console.WriteLine();
            }
        }

        public static int[] FindBlackHoles(char[,] matrix)
        {
            int[] position = new int[2];

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    if (matrix[r, c] == 'O')
                    {
                        position[0] = r;
                        position[1] = c;
                        break;
                    }
                }
            }

            return position;
        }

        public static bool IsInnside(char[,] matrix, int row, int col)
        {
            return row >= 0 && col >= 0 &&
                    row < matrix.GetLength(0) &&
                    col < matrix.GetLength(1);
        }
    }
}
