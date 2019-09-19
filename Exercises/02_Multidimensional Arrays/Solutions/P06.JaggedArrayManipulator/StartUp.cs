namespace P06.JaggedArrayManipulator
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int jaggedArrayRow = int.Parse(Console.ReadLine());

            double[][] jaggedArray = new double[jaggedArrayRow][];

            for (int row = 0; row < jaggedArrayRow; row++)
            {
                double[] currentRow = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();

                jaggedArray[row] = currentRow;
            }

            for (int row = 0; row < jaggedArrayRow - 1; row++)
            {
                if (jaggedArray[row].Length == jaggedArray[row + 1].Length)
                {
                    for (int col = 0; col < jaggedArray[row].Length; col++)
                    {
                        jaggedArray[row][col] *= 2;
                    }

                    for (int col = 0; col < jaggedArray[row + 1].Length; col++)
                    {
                        jaggedArray[row + 1][col] *= 2;
                    }
                }
                else
                {
                    for (int col = 0; col < jaggedArray[row].Length; col++)
                    {
                        jaggedArray[row][col] /= 2;
                    }

                    for (int col = 0; col < jaggedArray[row + 1].Length; col++)
                    {
                        jaggedArray[row + 1][col] /= 2;
                    }
                }
            }

            string currentOperator = string.Empty;

            while ((currentOperator = Console.ReadLine()) != "End")
            {
                string[] splittedOperator = currentOperator
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = splittedOperator[0];
                int row = int.Parse(splittedOperator[1]);
                int col = int.Parse(splittedOperator[2]);
                int value = int.Parse(splittedOperator[3]);

                if (IsInside(jaggedArray, row, col))
                {
                    if (command == "Add")
                    {
                        jaggedArray[row][col] += value;
                    }
                    else if (command == "Subtract")
                    {
                        jaggedArray[row][col] -= value;
                    }
                }
            }

            for (int row = 0; row < jaggedArrayRow; row++)
            {
                Console.WriteLine(string.Join(" ", jaggedArray[row]));
            }
        }

        private static bool IsInside(double[][] jaggedArray, int row, int col)
        {
            bool isInside = false;

            if (row >= 0 && col >= 0 && 
                jaggedArray.Length > row &&
                jaggedArray[row].Length > col)
            {
                isInside = true;
            }

            return isInside;
        }
    }
}
