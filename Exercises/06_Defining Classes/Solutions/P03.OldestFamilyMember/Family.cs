namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Family
    {
        private List<Person> familyMember;

        public Family()
        {
            familyMember = new List<Person>();
        }

        public void AddMember(Person person)
        {
            familyMember.Add(person);
        }

        public Person GetOldestMember()
        {
            Person oldestMember = familyMember
                .OrderByDescending(x => x.Age)
                .FirstOrDefault();

            return oldestMember;
        }
    }
}
