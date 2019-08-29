using System;
using System.Collections.Generic;
using System.Linq;

namespace P08.BalancedParenthesis
{
    class Program
    {
        static void Main()
        {
            char[] input = Console.ReadLine()
                .ToCharArray();

            Stack<char> openParentheses = new Stack<char>();

            char[] openingCharacters = new char[] { '(', '[', '{' };
            bool isBalanced = true;

            foreach (var character in input)
            {
                if (openingCharacters.Contains(character))
                {
                    openParentheses.Push(character);
                    continue;
                }

                if (openParentheses.Count == 0)
                {
                    isBalanced = false;
                    break;
                }

                else if (openParentheses.Peek() == '(' && character == ')')
                {
                    openParentheses.Pop();
                }
                else if (openParentheses.Peek() == '[' && character == ']')
                {
                    openParentheses.Pop();
                }
                else if (openParentheses.Peek() == '{' && character == '}')
                {
                    openParentheses.Pop();
                }
                else
                {
                    isBalanced = false;
                    break;
                }
            }

            if (isBalanced)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
