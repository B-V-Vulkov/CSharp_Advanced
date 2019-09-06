namespace P06.GenericCountMethodDouble
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            Box<double> box = new Box<double>();

            int lines = int.Parse(Console.ReadLine());

            for (int i = 1; i <= lines; i++)
            {
                double element = double.Parse(Console.ReadLine());
                box.Add(element);
            }

            double stringToCopare = double.Parse(Console.ReadLine());
            box.Compare(stringToCopare);

            Console.WriteLine(box.CountGreater);
        }
    }
}
