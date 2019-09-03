namespace P11.ThePartyReservationFilterModule
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string[] names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            List<string> filters = new List<string>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Print")
            {
                string[] splittedInput = input
                    .Split(";", StringSplitOptions.RemoveEmptyEntries);

                string command = splittedInput[0];
                string typeFilter = splittedInput[1];
                string param = splittedInput[2];

                if (command == "Add filter")
                {
                    filters.Add($"{typeFilter}_{param}");
                }
                else if (command == "Remove filter")
                {
                    filters.Remove($"{typeFilter}_{param}");
                }
            }

            Func<string, string, bool> startsWith = (name, param) => name.StartsWith(param);
            Func<string, string, bool> endsWith = (name, param) => name.EndsWith(param);
            Func<string, int, bool> length = (name, nameLength) => name.Length == nameLength;
            Func<string, string, bool> contains = (name, param) => name.Contains(param);

            foreach (var filterInfo in filters)
            {
                string[] splittedFilterInfo = filterInfo
                    .Split("_");

                string filter = splittedFilterInfo[0];
                string param = splittedFilterInfo[1];

                if (filter == "Starts with")
                {
                    names = names.Where(name => !startsWith(name, param)).ToArray();
                }
                else if (filter == "Ends with")
                {
                    names = names.Where(name => !endsWith(name, param)).ToArray();
                }
                else if (filter == "Length")
                {
                    int nameLength = int.Parse(param);
                    names = names.Where(name => !length(name, nameLength)).ToArray();
                }
                else if (filter == "Contains")
                {
                    names = names.Where(name => !contains(name, param)).ToArray();
                }
            }

            Console.WriteLine(string.Join(" ", names));
        }
    }
}
