namespace DefiningClasses
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            Person firstPerson = new Person();
            Person secontPerson = new Person();
            Person thirdPerson = new Person();

            firstPerson.Name = "Pesho";
            firstPerson.Age = 20;

            secontPerson.Name = "Gosho";
            secontPerson.Age = 18;

            thirdPerson.Name = "Stamat";
            thirdPerson.Age = 43;
        }
    }
}
