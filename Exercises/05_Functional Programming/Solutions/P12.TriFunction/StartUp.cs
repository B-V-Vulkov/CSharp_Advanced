namespace P12.TriFunction
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int length = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Func<string, int, bool> isLarger = (name, charsLarger) =>
                name.Sum(x => x) >= charsLarger;

            Func<string[], Func<string, int, bool>, string> nameFilter =
                (inputNames, isLargerFilter) => 
                inputNames.FirstOrDefault(x => isLargerFilter(x, length));

            string resultName = nameFilter(names, isLarger);
            Console.WriteLine(resultName);
        }
    }
}
