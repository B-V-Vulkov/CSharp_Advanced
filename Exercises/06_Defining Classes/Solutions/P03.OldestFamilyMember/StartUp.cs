﻿namespace DefiningClasses
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int people = int.Parse(Console.ReadLine());
            Family family = new Family();

            for (int i = 1; i <= people; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = input[0];
                int age = int.Parse(input[1]);

                family.AddMember(new Person(name, age));
            }

            Person oldestMember = family.GetOldestMember();

            Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
        }
    }
}
