using System.Collections.Generic;
using System.Linq;

namespace P03.Stack
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var elements = Console.ReadLine()
                .Split(',', ' ')
                .Skip(1)
                .ToArray();

            var customStack = new CustomStack<string>();

            foreach (var element in elements)
            {
                if (element != "")
                {
                    customStack.Push(element);
                }
            }

            string input = String.Empty;

            while ((input = Console.ReadLine()) != "END")
            {
                string command = input.Split(' ')[0];

                if (command == "Pop")
                {
                    try
                    {
                        customStack.Pop();
                    }
                    catch (InvalidOperationException ioex)
                    {
                        Console.WriteLine(ioex.Message);
                    }
                }
                else if (command == "Push")
                {
                    customStack.Push(input.Split(' ')[1]);
                }
            }

            foreach (var element in customStack)
            {
                Console.WriteLine(element);
            }
            foreach (var element in customStack)
            {
                Console.WriteLine(element);
            }
        }
    }
}
