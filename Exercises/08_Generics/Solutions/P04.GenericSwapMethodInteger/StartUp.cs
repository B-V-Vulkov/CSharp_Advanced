namespace P04.GenericSwapMethodInteger
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            Box<int> box = new Box<int>();

            int lines = int.Parse(Console.ReadLine());

            for (int i = 1; i <= lines; i++)
            {
                int element = int.Parse(Console.ReadLine());
                box.Add(element);
            }

            int[] indexes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int index1 = indexes[0];
            int index2 = indexes[1];

            box.Swap(index1, index2);
            Console.WriteLine(box);
        }
    }
}
