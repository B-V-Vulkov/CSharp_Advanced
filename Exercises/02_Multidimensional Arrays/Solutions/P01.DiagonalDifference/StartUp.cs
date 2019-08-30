namespace P01.DiagonalDifference
{
    using System;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            int[,] arr = new int[size, size];

            for (int row = 0; row < arr.GetLength(0); row++)
            {
                int[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < arr.GetLength(1); col++)
                {
                    arr[row, col] = input[col];
                }
            }

            int sumPrimaryDiagonal = 0;
            int sumSecondaryDiagonal = 0;

            for (int row = 0; row < arr.GetLength(0); row++)
            {
                for (int col = 0; col < arr.GetLength(1); col++)
                {
                    if (row == col)
                    {
                        sumPrimaryDiagonal += arr[row, col];
                    }
                    if (row + col == arr.GetLength(0) - 1)
                    {
                        sumSecondaryDiagonal += arr[row, col];
                    }
                }
            }

            int result = Math.Abs(sumPrimaryDiagonal - sumSecondaryDiagonal);
            Console.WriteLine(result);
        }
    }
}
