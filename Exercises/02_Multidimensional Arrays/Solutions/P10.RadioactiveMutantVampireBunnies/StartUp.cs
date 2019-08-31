namespace P10.RadioactiveMutantVampireBunnies
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int[] size = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            char[,] matrix = new char[size[0], size[1]];

            int currentRow = 0;
            int currentCol = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] inputRow = Console.ReadLine().ToCharArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = inputRow[col];

                    if (matrix[row, col] == 'P')
                    {
                        currentRow = row;
                        currentCol = col;
                    }
                }
            }

            char[] inputCommands = Console.ReadLine().ToCharArray();
            Queue<char> commands = new Queue<char>(inputCommands);

            bool isDead = false;
            bool isWon = false;

            while ((!isDead && !isWon))
            {
                char command = commands.Dequeue();
                matrix[currentRow, currentCol] = '.';

                if (command == 'U')
                {
                    if (IsInside(matrix, currentRow - 1, currentCol))
                    {
                        currentRow -= 1;
                        if (matrix[currentRow, currentCol] != '.')
                        {
                            isDead = true;
                        }
                        else
                        {
                            matrix[currentRow, currentCol] = 'P';
                        }
                    }
                    else
                    {
                        isWon = true;
                    }
                }

                if (command == 'R')
                {
                    if (IsInside(matrix, currentRow, currentCol + 1))
                    {
                        currentCol += 1;
                        if (matrix[currentRow, currentCol] != '.')
                        {
                            isDead = true;
                        }
                        else
                        {
                            matrix[currentRow, currentCol] = 'P';
                        }
                    }
                    else
                    {
                        isWon = true;
                    }
                }

                if (command == 'D')
                {
                    if (IsInside(matrix, currentRow + 1, currentCol))
                    {
                        currentRow += 1;
                        if (matrix[currentRow, currentCol] != '.')
                        {
                            isDead = true;
                        }
                        else
                        {
                            matrix[currentRow, currentCol] = 'P';
                        }
                    }
                    else
                    {
                        isWon = true;
                    }
                }

                if (command == 'L')
                {
                    if (IsInside(matrix, currentRow, currentCol - 1))
                    {
                        currentCol -= 1;
                        if (matrix[currentRow, currentCol] != '.')
                        {
                            isDead = true;
                        }
                        else
                        {
                            matrix[currentRow, currentCol] = 'P';
                        }
                    }
                    else
                    {
                        isWon = true;
                    }
                }

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (matrix[row, col] == 'B')
                        {
                            matrix = MutationOfBunnies(matrix, row, col);
                        }
                    }
                }

                for (int row= 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (matrix[row, col] == 'b')
                        {
                            matrix[row, col] = 'B';
                        }
                    }
                }

                bool isStillLive = false;

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (matrix[row, col] == 'P')
                        {
                            isStillLive = true;
                            break;
                        }
                    }
                    if (isStillLive)
                    {
                        break;
                    }
                }

                if (!isStillLive)
                {
                    isDead = true;
                }
            }


            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }

            if (isWon)
            {
                Console.WriteLine("won: {0} {1}", currentRow, currentCol);
            }
            else
            {
                Console.WriteLine("dead: {0} {1}", currentRow, currentCol);
            }
        }

        private static bool IsInside(char[,] matrix, int row, int col)
        {
            return row >= 0 && col >= 0 &&
                row < matrix.GetLength(0) &&
                col < matrix.GetLength(1);
        }

        private static char[,] MutationOfBunnies(char[,] matrix, int positionsOfRow, int positionsOfCol)
        {
            if (IsInside(matrix, positionsOfRow - 1, positionsOfCol) && matrix[positionsOfRow - 1, positionsOfCol] != 'B')
            {
                matrix[positionsOfRow - 1, positionsOfCol] = 'b';
            }

            if (IsInside(matrix, positionsOfRow, positionsOfCol + 1) && matrix[positionsOfRow, positionsOfCol + 1] != 'B')
            {
                matrix[positionsOfRow, positionsOfCol + 1] = 'b';
            }

            if (IsInside(matrix, positionsOfRow + 1, positionsOfCol) && matrix[positionsOfRow + 1, positionsOfCol] != 'B')
            {
                matrix[positionsOfRow + 1, positionsOfCol] = 'b';
            }

            if (IsInside(matrix, positionsOfRow, positionsOfCol - 1) && matrix[positionsOfRow, positionsOfCol - 1] != 'B')
            {
                matrix[positionsOfRow, positionsOfCol - 1] = 'b';
            }

            return matrix;
        }
    }
}
