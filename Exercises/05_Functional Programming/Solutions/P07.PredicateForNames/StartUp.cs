namespace P07.PredicateForNames
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int lessNumber = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Predicate<string> isLess = name => name.Length <= lessNumber;

            names = names.Where(name => isLess(name)).ToArray();

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
