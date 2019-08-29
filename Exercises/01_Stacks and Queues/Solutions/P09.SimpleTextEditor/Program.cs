using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P09.SimpleTextEditor
{
    class Program
    {
        static void Main()
        {
            Stack<string> stackOfText = new Stack<string>();
            StringBuilder text = new StringBuilder();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string command = input[0];

                switch (command)
                {
                    case "1":
                        string addedText = input[1];
                        stackOfText.Push(text.ToString());
                        text.Append(addedText);
                        break;

                    case "2":
                        int indexRemove = int.Parse(input[1]);
                        stackOfText.Push(text.ToString());
                        text.Remove(text.Length - indexRemove, indexRemove);
                        break;

                    case "3":
                        int indexPrint = int.Parse(input[1]);
                        Console.WriteLine(text[indexPrint - 1]);
                        break;

                    case "4":
                        text.Clear();
                        text.Append(stackOfText.Pop());
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
