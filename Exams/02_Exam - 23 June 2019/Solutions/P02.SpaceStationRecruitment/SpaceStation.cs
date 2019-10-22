namespace SpaceStationRecruitment
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class SpaceStation
    {
        private List<Astronaut> date;

        public SpaceStation(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.date = new List<Astronaut>();
        }

        public string Name { get; }

        public int Capacity { get; private set; }

        public int Count 
        {
            get { return this.date.Count; }
        }

        public void Add(Astronaut astronaut)
        {
            if (this.Capacity > this.Count)
            {
                this.date.Add(astronaut);
            }
        }

        public bool Remove(string name)
        {
            var astronautForDelete = this.date
                .FirstOrDefault(n => n.Name == name);

            if (astronautForDelete == null)
            {
                return false;
            }
            
            this.date.Remove(astronautForDelete);
            return true;
        }

        public Astronaut GetOldestAstronaut()
        {
            var OldestAstronaut = this.date
                .OrderByDescending(a => a.Age)
                .FirstOrDefault();

            return OldestAstronaut;
        }

        public Astronaut GetAstronaut(string name)
        {
            var astronaut = this.date
                .FirstOrDefault(n => n.Name == name);

            return astronaut;
        }

        public string Report() 
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"Astronauts working at Space Station {this.Name}:");

            foreach (var astronaut in date)
            {
                stringBuilder.AppendLine(astronaut.ToString());
            }

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
