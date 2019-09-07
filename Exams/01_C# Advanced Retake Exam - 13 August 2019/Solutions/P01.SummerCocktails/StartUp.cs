namespace P01.SummerCocktails
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int[] ingredientsInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] freshnessLevelInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> ingredients = new Queue<int>(ingredientsInput);
            Stack<int> freshnessLevel = new Stack<int>(freshnessLevelInput);

            Dictionary<string, int> cocktails = new Dictionary<string, int>
            {
                { "Mimosa", 0 },
                { "Daiquiri", 0 },
                { "Sunshine", 0 },
                { "Mojito", 0 }
            };

            while (ingredients.Count != 0 && freshnessLevel.Count != 0)
            {
                int currentIngredients = ingredients.Dequeue();

                if (currentIngredients == 0)
                {
                    continue;
                }

                int currentFreshnessLevel = freshnessLevel.Pop();
                int totalFreshnessLevel = currentIngredients * currentFreshnessLevel;

                if (totalFreshnessLevel == 400)
                {
                    cocktails["Mojito"]++;
                }
                else if (totalFreshnessLevel == 300)
                {
                    cocktails["Sunshine"]++;
                }
                else if (totalFreshnessLevel == 250)
                {
                    cocktails["Daiquiri"]++;
                }
                else if (totalFreshnessLevel == 150)
                {
                    cocktails["Mimosa"]++;
                }
                else
                {
                    currentIngredients += 5;
                    ingredients.Enqueue(currentIngredients);
                }
            }

            bool isDone = true;

            foreach (var cocktail in cocktails)
            {
                if (cocktail.Value == 0)
                {
                    isDone = false;
                }
            }

            if (isDone)
            {
                Console.WriteLine("It's party time! The cocktails are ready!");
            }
            else
            {
                Console.WriteLine("What a pity! You didn't manage to prepare all cocktails.");
            }

            int ingredientsLeft = ingredients.Sum();

            if (ingredientsLeft != 0)
            {
                Console.WriteLine($"Ingredients left: {ingredientsLeft}");
            }

            cocktails = cocktails
                .Where(x => x.Value != 0)
                .ToDictionary(x => x.Key, y => y.Value);

            foreach (var cocktail in cocktails.OrderBy(x => x.Key))
            {
                Console.WriteLine($" # {cocktail.Key} --> {cocktail.Value}");
            }
        }
    }
}
