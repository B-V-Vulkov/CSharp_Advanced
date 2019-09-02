namespace P02.KnightsOfHonor
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            Action<string[]> printNames = names =>
                Console.WriteLine("Sir " + string.Join(Environment.NewLine + "Sir ", names));

            string[] inputNames = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            printNames(inputNames);
        }
    }
}
