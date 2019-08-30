namespace P05.SnakeMoves
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

            char[,] stringArray = new char[size[0], size[1]]; 

            string str = Console.ReadLine();

            int index = 0;

            for (int row = 0; row < stringArray.GetLength(0); row++)
            {
                for (int col = 0; col < stringArray.GetLength(1); col++)
                {
                    if (index == str.Length)
                    {
                        index = 0;
                    }
                    stringArray[row, col] = str[index];
                    index++;
                }
            }

            for (int row = 0; row < stringArray.GetLength(0); row++)
            {
                for (int col = 0; col < stringArray.GetLength(1); col++)
                {
                    Console.Write(stringArray[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
