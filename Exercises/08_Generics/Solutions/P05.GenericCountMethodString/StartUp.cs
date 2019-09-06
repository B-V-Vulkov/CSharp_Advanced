namespace P05.GenericCountMethodString
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            Box<string> box = new Box<string>();

            int lines = int.Parse(Console.ReadLine());

            for (int i = 1; i <= lines; i++)
            {
                string element = Console.ReadLine();
                box.Add(element);
            }

            string stringToCopare = Console.ReadLine();
            box.Compare(stringToCopare);

            Console.WriteLine(box.CountGreater);
        }
    }
}
