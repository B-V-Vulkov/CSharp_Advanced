namespace P01.GenericBoxOfString
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            Box<string> box = new Box<string>();

            int lines = int.Parse(Console.ReadLine());

            for (int i = 1; i <= lines; i++)
            {
                box.Add(Console.ReadLine());
            }

            Console.WriteLine(box.ToString());

        }
    }
}
