namespace P07.TheV_Logge
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var vloggers = new Dictionary<string, Dictionary<string, HashSet<string>>>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Statistics")
            {
                string[] splittedInput = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string command = splittedInput[1];

                if (command == "joined")
                {
                    string joinedVLogger = splittedInput[0];

                    if (!vloggers.ContainsKey(joinedVLogger))
                    {
                        vloggers.Add(joinedVLogger, new Dictionary<string, HashSet<string>>());
                        vloggers[joinedVLogger].Add("followers", new HashSet<string>());
                        vloggers[joinedVLogger].Add("following", new HashSet<string>());
                    }
                }

                else if (command == "followed")
                {
                    string followers = splittedInput[0];
                    string following = splittedInput[2];

                    if (followers != following && vloggers.ContainsKey(followers) && vloggers.ContainsKey(following))
                    {
                        vloggers[followers]["following"].Add(following);
                        vloggers[following]["followers"].Add(followers);
                    }
                }
            }

            vloggers = vloggers
                .OrderByDescending(kvp => kvp.Value["followers"].Count)
                .ThenBy(kvp => kvp.Value["following"].Count)
                .ToDictionary(x => x.Key, y => y.Value);

            Console.WriteLine("The V-Logger has a total of {0} vloggers in its logs.", vloggers.Count);

            int counter = 0;

            foreach (var vlogger in vloggers)
            {
                counter++;

                Console.WriteLine("{0}. {1} : {2} followers, {3} following", 
                        counter, vlogger.Key, vlogger.Value["followers"].Count, vlogger.Value["following"].Count);

                if (counter == 1)
                {
                    foreach (var followers in vlogger.Value["followers"].OrderBy(kvp => kvp))
                    {
                        Console.WriteLine("*  {0}", followers);
                    }
                }
            }
        }
    }
}
