namespace P09.Miner
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];

            string[] commandsInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Queue<string> commands = new Queue<string>(commandsInput);

            int currentRow = 0;
            int currentCol = 0;

            for (int row = 0; row < size; row++)
            {
                char[] inputRow = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = inputRow[col];

                    if (matrix[row, col] == 's')
                    {
                        currentRow = row;
                        currentCol = col;
                    }
                }
            }

            int countOfCoal = 0;
            bool isSteps = false;

            while (commands.Count != 0)
            {
                string command = commands.Dequeue();

                int nextRow = 0;
                int nextCol = 0;

                if (command == "up" && IsInside(matrix, currentRow - 1, currentCol))
                {
                    nextRow = currentRow - 1;
                    nextCol = currentCol;

                    if (matrix[nextRow, nextCol] == 'e')
                    {
                        currentRow = nextRow;
                        currentCol = nextCol;
                        isSteps = true;
                        break;
                    }
                    else if (matrix[nextRow, nextCol] == 'c')
                    {
                        countOfCoal++;
                    }

                    matrix[nextRow, nextCol] = 's';
                    matrix[currentRow, currentCol] = '*';
                    currentRow = nextRow;
                    currentCol = nextCol;
                }

                if (command == "right" && IsInside(matrix, currentRow, currentCol + 1))
                {
                    nextRow = currentRow;
                    nextCol = currentCol + 1;

                    if (matrix[nextRow, nextCol] == 'e')
                    {
                        currentRow = nextRow;
                        currentCol = nextCol;
                        isSteps = true;
                        break;
                    }
                    else if (matrix[nextRow, nextCol] == 'c')
                    {
                        countOfCoal++;
                    }

                    matrix[nextRow, nextCol] = 's';
                    matrix[currentRow, currentCol] = '*';
                    currentRow = nextRow;
                    currentCol = nextCol;
                }

                if (command == "down" && IsInside(matrix, currentRow + 1, currentCol))
                {
                    nextRow = currentRow + 1;
                    nextCol = currentCol;

                    if (matrix[nextRow, nextCol] == 'e')
                    {
                        currentRow = nextRow;
                        currentCol = nextCol;
                        isSteps = true;
                        break;
                    }
                    else if (matrix[nextRow, nextCol] == 'c')
                    {
                        countOfCoal++;
                    }

                    matrix[nextRow, nextCol] = 's';
                    matrix[currentRow, currentCol] = '*';
                    currentRow = nextRow;
                    currentCol = nextCol;
                }

                if (command == "left" && IsInside(matrix, currentRow, currentCol - 1))
                {
                    nextRow = currentRow;
                    nextCol = currentCol - 1;

                    if (matrix[nextRow, nextCol] == 'e')
                    {
                        currentRow = nextRow;
                        currentCol = nextCol;
                        isSteps = true;
                        break;
                    }
                    else if (matrix[nextRow, nextCol] == 'c')
                    {
                        countOfCoal++;
                    }

                    matrix[nextRow, nextCol] = 's';
                    matrix[currentRow, currentCol] = '*';
                    currentRow = nextRow;
                    currentCol = nextCol;
                }
            }

            if (isSteps)
            {
                Console.WriteLine("Game over! ({0}, {1})", currentRow, currentCol);
            }
            else
            {
                int coalsLeft = 0;

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (matrix[row, col] == 'c')
                        {
                            coalsLeft++;
                        }
                    }
                }

                if (coalsLeft == 0)
                {
                    Console.WriteLine("You collected all coals! ({0}, {1})", currentRow, currentCol);
                }
                else
                {
                    Console.WriteLine("{0} coals left. ({1}, {2})", coalsLeft, currentRow, currentCol);
                }
            }
        }

        private static bool IsInside(char[,] matrix, int row, int col)
        {
            return row >= 0 && col >= 0 &&
                row < matrix.GetLength(0) &&
                col < matrix.GetLength(1);
        }
    }
}
