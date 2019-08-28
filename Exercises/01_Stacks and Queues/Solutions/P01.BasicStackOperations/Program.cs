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

            bool isNotFound = true;
            int smallestElment = int.MaxValue;

            foreach (var element in stack)
            {
                if (element == searchElement)
                {
                    Console.WriteLine("true");
                    isNotFound = false;
                    break;
                }
                else
                {
                    if (element < smallestElment)
                    {
                        smallestElment = element;
                    }
                }
            }

            if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (isNotFound)
            {
                Console.WriteLine(smallestElment);
            }
        }

        public static int[] ToIntArray(string input)
        {
            int[] resul = input.Split(" ")
                .Select(int.Parse)
                .ToArray();

            return resul;
        }
    }
}