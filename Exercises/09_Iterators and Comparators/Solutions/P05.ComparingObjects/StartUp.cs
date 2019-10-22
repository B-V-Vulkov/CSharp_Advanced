namespace P05.ComparingObjects
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var people = new List<Person>();

            string command = String.Empty;

            while ((command = Console.ReadLine()) != "END")
            {
                string[] personInfo = command.Split(' ');

                string name = personInfo[0];
                int age = int.Parse(personInfo[1]);
                string town = personInfo[2];

                var person = new Person(name, age, town);

                people.Add(person);
            }

            var index = int.Parse(Console.ReadLine());

            var targetPerson = people[index - 1];
            
            int countMatches = 1;

            foreach (var person in people)
            {
                if (person.CompareTo(targetPerson) == 0 && !person.Equals(targetPerson))
                {
                    countMatches++;
                }
            }

            if (countMatches == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{countMatches} {people.Count - countMatches} {people.Count}");
            }
        }
    }
}
