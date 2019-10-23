namespace P02.HelensAbduction
{
    using System;

    public class StartUp
    {
        public static void Main(String[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            int size = int.Parse(Console.ReadLine());

            char[][] matrix = new char[size][];

            int row = 0;
            int col = 0;

            for (int r = 0; r < matrix.Length; r++)
            {
                string currentRow = Console.ReadLine();
                matrix[r] = new char[currentRow.Length];
                for (int c = 0; c < matrix[r].Length; c++)
                {
                    matrix[r][c] = currentRow[c];

                    if (currentRow[c] == 'P')
                    {
                        row = r;
                        col = c;
                    }
                }
            }

            while (true)
            {
                energy--;
                matrix[row][col] = '-';

                string[] input = Console.ReadLine()
                    .Split(' ');

                string command = input[0];
                int enemyRow = int.Parse(input[1]);
                int enemyCol = int.Parse(input[2]);

                matrix[enemyRow][enemyCol] = 'S';

                if (command == "up")
                {
                    if (IsInnside(matrix, row - 1, col))
                    {
                        row--;
                    }
                }
                else if (command == "down")
                {
                    if (IsInnside(matrix, row + 1, col))
                    {
                        row++;
                    }
                }
                else if (command == "left")
                {
                    if (IsInnside(matrix, row, col - 1))
                    {
                        col--;
                    }
                }
                else if (command == "right")
                {
                    if (IsInnside(matrix, row, col + 1))
                    {
                        col++;
                    }
                }

                if (matrix[row][col] == 'S')
                {
                    energy -= 2;
                }

                else if (matrix[row][col] == 'H')
                {
                    matrix[row][col] = '-';
                    Console.WriteLine($"Paris has successfully abducted Helen! Energy left: {energy}");
                    break;
                }

                if (energy <= 0)
                {
                    matrix[row][col] = 'X';
                    Console.WriteLine($"Paris died at {row};{col}.");
                    break;
                }
            }

            for (int r = 0; r < matrix.Length; r++)
            {
                for (int c = 0; c < matrix[r].Length; c++)
                {
                    Console.Write(matrix[r][c]);
                }
                Console.WriteLine();
            }
        }

        public static bool IsInnside(char[][] matrix, int row, int col)
        {
            return row >= 0 && col >= 0 &&
                row < matrix.Length &&
                col < matrix[row].Length;
        }
    }
}
