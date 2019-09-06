namespace P02.GenericBoxOfInteger
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            Box<int> box = new Box<int>();
            int lines = int.Parse(Console.ReadLine());
            for (int i = 1; i <= lines; i++)
            {
                int item = int.Parse(Console.ReadLine());
                box.Add(item);
            }

            Console.WriteLine(box);
        }
    }
}
