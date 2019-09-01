namespace P08.Ranking
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var contests = new Dictionary<string, string>();
            var candidates = new Dictionary<string, Dictionary<string, int>>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end of contests")
            {
                string[] splittedInput = input.Split(":");
                string contest = splittedInput[0];
                string password = splittedInput[1];

                if (!contests.ContainsKey(contest))
                {
                    contests.Add(contest, password);
                }
            }

            while ((input = Console.ReadLine()) != "end of submissions")
            {
                string[] splittedInput = input.Split("=>");
                string contest = splittedInput[0];
                string password = splittedInput[1];
                string name = splittedInput[2];
                int points = int.Parse(splittedInput[3]);

                if (contests.ContainsKey(contest) && contests[contest] == password)
                {
                    if (!candidates.ContainsKey(name))
                    {
                        candidates.Add(name, new Dictionary<string, int>());
                        candidates[name].Add(contest, points);
                    }
                    else if (!candidates[name].ContainsKey(contest))
                    {
                        candidates[name].Add(contest, points);
                    }
                    else if (candidates[name][contest] < points)
                    {
                        candidates[name][contest] = points;
                    }
                }
            }

            int maxPoints = 0;
            string bestCandidate = string.Empty;

            foreach (var candidate in candidates)
            {
                int currentSum = 0;

                foreach (var points in candidate.Value)
                {
                    currentSum += points.Value;
                }

                if (currentSum > maxPoints)
                {
                    maxPoints = currentSum;
                    bestCandidate = candidate.Key;
                }
            }

            Console.WriteLine("Best candidate is {0} with total {1} points.", bestCandidate, maxPoints);
            Console.WriteLine("Ranking:");

            foreach (var candidate in candidates.OrderBy(kvp => kvp.Key))
            {
                Console.WriteLine(candidate.Key);

                foreach (var contest in candidate.Value.OrderByDescending(kvp => kvp.Value))
                {
                    Console.WriteLine("#  {0} -> {1}", contest.Key, contest.Value);
                }
            }
        }
    }
}
