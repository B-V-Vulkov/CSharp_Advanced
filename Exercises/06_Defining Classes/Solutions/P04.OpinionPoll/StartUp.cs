namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int countOfPeople = int.Parse(Console.ReadLine());

            Family family = new Family();

            for (int i = 1; i <= countOfPeople; i++)
            {
                string[] peopleInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string currentName = peopleInfo[0];
                int currentAge = int.Parse(peopleInfo[1]);

                Person currentPerson = new Person(currentName, currentAge);

                family.AddMember(currentPerson);
            }

            List<Person> oldMembers = family.GetOldMembers(30);
            oldMembers = oldMembers
                .OrderBy(x => x.Name)
                .ToList();

            foreach (var person in oldMembers)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
