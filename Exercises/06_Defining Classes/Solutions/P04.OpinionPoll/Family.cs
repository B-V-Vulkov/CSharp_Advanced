namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Family
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

        public List<Person> GetOldMembers(int years)
        {
            List<Person> oldMembers = familyMember
                .Where(x => x.Age > years)
                .ToList();

            return oldMembers;
        }
    }
}
