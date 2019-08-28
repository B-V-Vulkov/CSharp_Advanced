using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.BasicStackOperations
{
    class Program
    {
        static void Main()
        {
            int[] commands = ToIntArray(Console.ReadLine());

            int pushElements = commands[0];
            int popElements = commands[1];
            int searchElement = commands[2];

            Stack<int> stack = new Stack<int>();

            int[] splittedInput = ToIntArray(Console.ReadLine());

            for (int i = 0; i < pushElements; i++)
            {
                stack.Push(splittedInput[i]);
            }

            for (int i = 0; i < popElements; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(searchElement))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (stack.Count != 0)
                {
                    Console.WriteLine(stack.Min());
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
        }

        public static int[] ToIntArray(string input)
        {
            int[] resul = input.Split(" ").Select(int.Parse).ToArray();
            return resul;
        }
    }
}