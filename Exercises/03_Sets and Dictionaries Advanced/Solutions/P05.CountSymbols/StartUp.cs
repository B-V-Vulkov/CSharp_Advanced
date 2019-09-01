namespace P05.CountSymbols
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            char[] input = Console.ReadLine().ToCharArray();
            SortedDictionary<char, int> symbols = new SortedDictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];

                if (!symbols.ContainsKey(currentChar))
                {
                    symbols.Add(input[i], 0);
                }

                symbols[currentChar]++;
            }

            foreach (var symbol in symbols)
            {
                Console.WriteLine("{0}: {1} time/s", symbol.Key, symbol.Value);
            }
        }
    }
}
