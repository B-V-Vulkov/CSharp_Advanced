namespace P10.PredicateParty
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<string> names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input = string.Empty;

            Func<string, string, bool> startsWith = (name, param) => name.StartsWith(param);
            Func<string, string, bool> endsWith = (name, param) => name.EndsWith(param);
            Func<string, int, bool> length = (name, lenght) => name.Length == lenght;

            while ((input = Console.ReadLine()) != "Party!")
            {
                string[] splittedInput = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = splittedInput[0];
                string action = splittedInput[1];
                string param = splittedInput[2];

                if (command == "Double")
                {
                    List<string> currentNames = new List<string>();

                    switch (action)
                    {
                        case "StartsWith":
                            for (int i = 0; i < names.Count; i++)
                            {
                                currentNames.Add(names[i]);
                                if (startsWith(names[i], param))
                                {
                                    currentNames.Add(names[i]);
                                }
                            }
                            names = currentNames;
                            break;

                        case "EndsWith":
                            for (int i = 0; i < names.Count; i++)
                            {
                                currentNames.Add(names[i]);
                                if (endsWith(names[i], param))
                                {
                                    currentNames.Add(names[i]);
                                }
                            }
                            names = currentNames;
                            break;

                        case "Length":
                            int currentLength = int.Parse(param);
                            for (int i = 0; i < names.Count; i++)
                            {
                                currentNames.Add(names[i]);
                                if (length(names[i], currentLength))
                                {
                                    currentNames.Add(names[i]);
                                }
                            }
                            names = currentNames;
                            break;
                        default:
                            break;
                    }
                }
                else if (command == "Remove")
                {
                    switch (action)
                    {
                        case "StartsWith":
                            names = names.Where(name => !startsWith(name, param)).ToList();
                            break;

                        case "EndsWith":
                            names = names.Where(name => !endsWith(name, param)).ToList();
                            break;

                        case "Length":
                            int currentLength = int.Parse(param);
                            names = names.Where(name => !length(name, currentLength)).ToList();
                            break;
                        default:
                            break;
                    }
                }
            }

            if (names.Count != 0)
            {
                Console.Write(string.Join(", ", names));
                Console.WriteLine(" are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }
    }
}
