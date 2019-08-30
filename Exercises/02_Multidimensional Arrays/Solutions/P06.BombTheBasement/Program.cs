namespace P06.BombTheBasement
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int[] size = ToIntArray(Console.ReadLine());

            int rows = size[0];
            int cols = size[1];
            int[,] matrix = new int[rows, cols];

            int[] bombParameters = ToIntArray(Console.ReadLine());
            int positionsOfRow = bombParameters[0];
            int positionsOfCol = bombParameters[1];
            int radius = bombParameters[2];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    bool isInRadius = Math.Pow(row - positionsOfRow, 2) + Math.Pow(col - positionsOfCol, 2) <= Math.Pow(radius, 2);

                    if (isInRadius)
                    {
                        matrix[row, col] = 1;
                    }
                }
            }

            int[,] result = new int[rows, cols];

            for (int row = 0; row < result.GetLength(0); row++)
            {
                int currentMaxRow = IndexOfMaxSumOfRow(matrix);

                for (int col = 0; col < result.GetLength(1); col++)
                {
                    result[row, col] = matrix[currentMaxRow, col];
                    matrix[currentMaxRow, col] = 0;
                }
            }

            for (int row = 0; row < result.GetLength(0); row++)
            {
                for (int col = 0; col < result.GetLength(1); col++)
                {
                    Console.Write(result[row, col]);
                }
                Console.WriteLine();
            }
        }

        private static int[] ToIntArray(string input)
        {
            int[] result = input
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            return result;
        }

        private static int IndexOfMaxSumOfRow(int[,] input)
        {
            int result = 0;
            int maxSum = 0;

            for (int row = 0; row < input.GetLength(0); row++)
            {
                int currentSum = 0;

                for (int col = 0; col < input.GetLength(1); col++)
                {
                    currentSum += input[row, col];
                }

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    result = row;
                }
            }

            return result;
        }
    }
}
