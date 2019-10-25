namespace P02.TronRacers
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            char[][] matrix = new char[size][];

            int rowFP = 0;
            int colFP = 0;
            int rowSP = 0;
            int colSP = 0;

            for (int row = 0; row < matrix.Length; row++)
            {
                string currentRow = Console.ReadLine();

                matrix[row] = new char[currentRow.Length];

                for (int col = 0; col < matrix[row].Length; col++)
                {
                    matrix[row][col] = currentRow[col];

                    if (currentRow[col] == 'f')
                    {
                        rowFP = row;
                        colFP = col;
                    }
                    else if (currentRow[col] == 's')
                    {
                        rowSP = row;
                        colSP = col;
                    }
                }
            }

            while (true)
            {
                string[] commands = Console.ReadLine()
                    .Split(' ');

                string commandFP = commands[0];
                string commandSP = commands[1];

                if (commandFP == "up")
                {
                    rowFP--;

                    if (!IsInnside(matrix, rowFP, colFP))
                    {
                        rowFP = matrix.Length - 1;
                    }
                }
                else if (commandFP == "down")
                {
                    rowFP++;

                    if (!IsInnside(matrix, rowFP, colFP))
                    {
                        rowFP = 0;
                    }
                }
                else if (commandFP == "left")
                {
                    colFP--;

                    if (!IsInnside(matrix, rowFP, colFP))
                    {
                        colFP = matrix[rowFP].Length - 1;
                    }
                }
                else if (commandFP == "right")
                {
                    colFP++;

                    if (!IsInnside(matrix, rowFP, colFP))
                    {
                        colFP = 0;
                    }
                }

                if (matrix[rowFP][colFP] == 's')
                {
                    matrix[rowFP][colFP] = 'x';
                    break;
                }
                else
                {
                    matrix[rowFP][colFP] = 'f';
                }

                if (commandSP == "up")
                {
                    rowSP--;

                    if (!IsInnside(matrix, rowFP, colFP))
                    {
                        rowSP = matrix.Length - 1;
                    }
                }
                else if (commandSP == "down")
                {
                    rowSP++;

                    if (!IsInnside(matrix, rowFP, colFP))
                    {
                        rowSP = 0;
                    }
                }
                else if (commandSP == "left")
                {
                    colSP--;

                    if (!IsInnside(matrix, rowFP, colFP))
                    {
                        colSP = matrix[rowSP].Length - 1;
                    }
                }
                else if (commandSP == "right")
                {
                    colSP++;

                    if (!IsInnside(matrix, rowFP, colFP))
                    {
                        colSP = 0;
                    }
                }

                if (matrix[rowSP][colSP] == 'f')
                {
                    matrix[rowSP][colSP] = 'x';
                    break;
                }
                else
                {
                    matrix[rowSP][colSP] = 's';
                }
            }

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write(matrix[row][col]);
                }
                Console.WriteLine();
            }
        }

        public static bool IsInnside (char[][] matrix, int row, int col)
        {
            return row >= 0 && col >= 0 &&
                row < matrix.Length &&
                col < matrix[row].Length;
        }
    }
}
