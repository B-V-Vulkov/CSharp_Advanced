namespace P06.Wardrobe
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int inputs = int.Parse(Console.ReadLine());
            var wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < inputs; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string color = input[0];
                string[] clothes = input[1]
                    .Split(",", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }

                for (int clothing = 0; clothing < clothes.Length; clothing++)
                {
                    if (!wardrobe[color].ContainsKey(clothes[clothing]))
                    {
                        wardrobe[color].Add(clothes[clothing], 0);
                    }

                    wardrobe[color][clothes[clothing]]++;
                }
            }

            string[] searching = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string searchColor = searching[0];
            string searchClothing = searching[1];

            foreach (var color in wardrobe)
            {
                Console.WriteLine("{0} clothes:", color.Key);

                foreach (var clothing in color.Value)
                {
                    Console.Write("* {0} - {1}", clothing.Key, clothing.Value);

                    if (color.Key == searchColor && clothing.Key == searchClothing)
                    {
                        Console.Write(" (found!)");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
