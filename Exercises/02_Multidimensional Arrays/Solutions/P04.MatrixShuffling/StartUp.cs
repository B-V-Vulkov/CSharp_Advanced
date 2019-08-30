namespace P04.MatrixShuffling
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

            string[,] arr = new string[size[0], size[1]];

            for (int row = 0; row < arr.GetLength(0); row++)
            {
                string[] arrayRow = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (int col = 0; col < arr.GetLength(1); col++)
                {
                    arr[row, col] = arrayRow[col];
                }
            }

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] splitedInput = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                bool isNotValid = true;

                if (splitedInput.Length == 5)
                {
                    string command = splitedInput[0];
                    int positionRow1 = int.Parse(splitedInput[1]);
                    int positionCol1 = int.Parse(splitedInput[2]);
                    int positionRow2 = int.Parse(splitedInput[3]);
                    int positionCol2 = int.Parse(splitedInput[4]);

                    if (command == "swap" &&
                        positionRow1 >= 0 && positionRow1 < arr.GetLength(0) &&
                        positionRow2 >= 0 && positionRow2 < arr.GetLength(0) &&
                        positionCol1 >= 0 && positionCol1 < arr.GetLength(1) &&
                        positionRow2 >= 0 && positionRow2 < arr.GetLength(0))
                    {
                        string currentValue = arr[positionRow1, positionCol1];
                        arr[positionRow1, positionCol1] = arr[positionRow2, positionCol2];
                        arr[positionRow2, positionCol2] = currentValue;

                        isNotValid = false;

                        for (int row = 0; row < arr.GetLength(0); row++)
                        {
                            for (int col = 0; col < arr.GetLength(1); col++)
                            {
                                Console.Write("{0} ", arr[row, col]);
                            }
                            Console.WriteLine();
                        }
                    }
                }

                if (isNotValid)
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }
    }
}
