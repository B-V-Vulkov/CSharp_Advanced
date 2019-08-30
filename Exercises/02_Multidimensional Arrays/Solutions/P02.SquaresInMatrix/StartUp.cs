namespace P02.SquaresInMatrix
{
    using System;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            int[] size = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            char[,] arr = new char[size[0], size[1]];

            for (int row = 0; row < arr.GetLength(0); row++)
            {
                char[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int col = 0; col < arr.GetLength(1); col++)
                {
                    arr[row, col] = input[col];
                }
            }

            int count = 0;

            for (int row = 0; row < arr.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < arr.GetLength(1) - 1; col++)
                {
                    if ((arr[row, col] == arr[row, col + 1]) &&
                        (arr[row, col] == arr[row + 1, col]) &&
                        (arr[row, col] == arr[row + 1, col + 1]))
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);

        }
    }
}
