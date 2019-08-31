namespace P07.KnightGame
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] input = Console.ReadLine().ToCharArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            int counter = 0;

            while (true)
            {
                int maxCount = 0;
                int positionOfRow = 0;
                int positionOfCol = 0;

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (matrix[row, col] == 'K')
                        {
                            int currentCount = 0;

                            if (IsInside(matrix, row - 2, col - 1) && matrix[row - 2, col - 1] == 'K')
                            {
                                currentCount++;
                            }

                            if (IsInside(matrix, row - 2, col + 1) && matrix[row - 2, col + 1] == 'K')
                            {
                                currentCount++;
                            }

                            if (IsInside(matrix, row - 1, col + 2) && matrix[row - 1, col + 2] == 'K')
                            {
                                currentCount++;
                            }

                            if (IsInside(matrix, row + 1, col + 2) && matrix[row + 1, col + 2] == 'K')
                            {
                                currentCount++;
                            }

                            if (IsInside(matrix, row + 2, col + 1) && matrix[row + 2, col + 1] == 'K')
                            {
                                currentCount++;
                            }

                            if (IsInside(matrix, row + 2, col - 1) && matrix[row + 2, col - 1] == 'K')
                            {
                                currentCount++;
                            }

                            if (IsInside(matrix, row - 1, col - 2) && matrix[row - 1, col - 2] == 'K')
                            {
                                currentCount++;
                            }

                            if (IsInside(matrix, row + 1, col - 2) && matrix[row + 1, col - 2] == 'K')
                            {
                                currentCount++;
                            }

                            if (currentCount > maxCount)
                            {
                                maxCount = currentCount;
                                positionOfRow = row;
                                positionOfCol = col;
                            }
                        }
                    }
                }

                if (maxCount == 0)
                {
                    break;
                }

                matrix[positionOfRow, positionOfCol] = 'O';
                counter++;
            }

            Console.WriteLine(counter);
        }

        public static bool IsInside(char[,] matrix, int positionOfRow, int positionOfCol)
        {
            return positionOfRow >= 0 &&
                positionOfCol >= 0 &&
                positionOfRow < matrix.GetLength(0) &&
                positionOfCol < matrix.GetLength(1); 
        }
    }
}
