namespace P05.SnakeMoves2
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int[] size = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int matrixRows = size[0];
            int matricCols = size[1];

            char[,] matrix = new char[matrixRows, matricCols];

            string text = Console.ReadLine();
            int index = 0;

            for (int row = 0; row < matrixRows; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < matricCols; col++)
                    {
                        if (index == text.Length)
                        {
                            index = 0;
                        }

                        matrix[row, col] = text[index];
                        index++;
                    }
                }
                else
                {
                    for (int col = matricCols -1; col >= 0; col--)
                    {
                        if (index == text.Length)
                        {
                            index = 0;
                        }

                        matrix[row, col] = text[index];
                        index++;
                    }
                }

            }

            for (int row = 0; row < matrixRows; row++)
            {
                for (int col = 0; col < matricCols; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }


        }
    }
}
