namespace P08.Bombs
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];

            for (int row = 0; row < size; row++)
            {
                int[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            string[] targets = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            for (int target = 0; target < targets.Length; target++)
            {
                int[] currentTarget = targets[target]
                    .Split(",", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int row = currentTarget[0];
                int col = currentTarget[1];

                if (matrix[row, col] > 0)
                {
                    if (IsInside(matrix, row - 1, col - 1) && (matrix[row - 1, col - 1] > 0))
                    {
                        matrix[row - 1, col - 1] -= matrix[row, col];
                    }

                    if (IsInside(matrix, row - 1, col) && (matrix[row - 1, col] > 0))
                    {
                        matrix[row - 1, col] -= matrix[row, col];
                    }

                    if (IsInside(matrix, row - 1, col + 1) && (matrix[row - 1, col + 1] > 0))
                    {
                        matrix[row - 1, col + 1] -= matrix[row, col];
                    }

                    if (IsInside(matrix, row, col + 1) && (matrix[row, col + 1] > 0))
                    {
                        matrix[row, col + 1] -= matrix[row, col];
                    }

                    if (IsInside(matrix, row + 1, col + 1) && (matrix[row + 1, col + 1] > 0))
                    {
                        matrix[row + 1, col + 1] -= matrix[row, col];
                    }

                    if (IsInside(matrix, row + 1, col) && (matrix[row + 1, col] > 0))
                    {
                        matrix[row + 1, col] -= matrix[row, col];
                    }

                    if (IsInside(matrix, row + 1, col - 1) && (matrix[row + 1, col - 1] > 0))
                    {
                        matrix[row + 1, col - 1] -= matrix[row, col];
                    }

                    if (IsInside(matrix, row, col - 1) && (matrix[row, col - 1] > 0))
                    {
                        matrix[row, col - 1] -= matrix[row, col];
                    }

                    matrix[row, col] = 0;
                }
            }

            int aliveCells = 0;
            int sumAliveCells = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] > 0)
                    {
                        aliveCells++;
                        sumAliveCells += matrix[row, col];
                    }
                }
            }

            Console.WriteLine("Alive cells: {0}", aliveCells);
            Console.WriteLine("Sum: {0}", sumAliveCells);

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0} ", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        private static bool IsInside(int[,] matrix, int row, int col)
        {
            return row >= 0 && col >= 0 &&
                row < matrix.GetLength(0) &&
                col < matrix.GetLength(1);
        }
    }
}
