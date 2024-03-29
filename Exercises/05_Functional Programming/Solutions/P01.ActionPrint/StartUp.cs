﻿namespace P01.ActionPrint
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            Action<string[]> printNames = names =>
                Console.WriteLine(string.Join(Environment.NewLine, names));

            string[] inputNames = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            printNames(inputNames);
        }
    }
}
