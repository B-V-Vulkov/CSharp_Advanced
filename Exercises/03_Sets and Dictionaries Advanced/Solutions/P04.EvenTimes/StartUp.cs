namespace P04.EvenTimes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();

            for (int i = 0; i < lines; i++)
            {
                int input = int.Parse(Console.ReadLine());

                if (!keyValuePairs.ContainsKey(input))
                {
                    keyValuePairs.Add(input, 0);
                }

                keyValuePairs[input]++;
            }

            var result = keyValuePairs
                .SingleOrDefault(kvp => kvp.Value % 2 == 0)
                .Key;

            Console.WriteLine(result);
        }
    }
}
