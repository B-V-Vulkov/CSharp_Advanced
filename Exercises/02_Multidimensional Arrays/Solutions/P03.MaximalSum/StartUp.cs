namespace P03.MaximalSum
{
    using System;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            int[] size = ToIntArray(Console.ReadLine());

            int[,] arr = new int[size[0], size[1]];

            for (int row = 0; row < arr.GetLength(0); row++)
            {
                int[] input = ToIntArray(Console.ReadLine());

                for (int col = 0; col < arr.GetLength(1); col++)
                {
                    arr[row, col] = input[col];
                }
            }

            int maxSum = 0;
            int indexOfRow = 0;
            int indexOfCol = 0;

            for (int row = 0; row < arr.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < arr.GetLength(1) - 2; col++)
                {
                    int currentSum = arr[row, col] + arr[row, col + 1] + arr[row, col + 2] + 
                        arr[row + 1, col] + arr[row + 1, col + 1] + arr[row + 1, col + 2] + 
                        arr[row + 2, col] + arr[row + 2, col + 1] + arr[row + 2, col + 2];

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        indexOfRow = row;
                        indexOfCol = col;
                    }
                }
            }

            Console.WriteLine("Sum = {0}", maxSum);

            for (int row = indexOfRow; row < indexOfRow + 3; row++)
            {
                for (int col = indexOfCol; col < indexOfCol + 3; col++)
                {
                    Console.Write("{0} ", arr[row, col]);
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
    }
}
