namespace SpaceStationRecruitment
{
    public class Astronaut
    {
        public Astronaut(string name, int age, string country)
        {
            Name = name;
            Age = age;
            Country = country;
        }

        public string Name { get; }

        public int Age { get; }

        public string Country { get; }

        public override string ToString()
        {
            return $"Astronaut: {this.Name}, {this.Age} ({this.Country})";
        }
    }
}
