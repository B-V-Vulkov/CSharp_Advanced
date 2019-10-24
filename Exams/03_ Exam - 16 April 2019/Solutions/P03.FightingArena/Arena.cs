namespace FightingArena
{
    using System.Collections.Generic;
    using System.Linq;

    public class Arena
    {
        private ICollection<Gladiator> gladiators;

        public Arena(string name)
        {
            this.gladiators = new List<Gladiator>();
            this.Name = name;
        }

        public string Name { get; }

        public int Count
        {
            get { return this.gladiators.Count; }
        }

        public void Add(Gladiator gladiator)
        {
            this.gladiators.Add(gladiator);
        }

        public void Remove(string name)
        {
            var gladiator = this.gladiators
                .FirstOrDefault(n => n.Name == name);

            if (gladiator != null)
            {
                this.gladiators.Remove(gladiator);
            }
        }

        public Gladiator GetGladitorWithHighestStatPower()
        {
            return this.gladiators
                .OrderByDescending(p => p.GetStatPower())
                .FirstOrDefault();
        }

        public Gladiator GetGladitorWithHighestWeaponPower()
        {
            return this.gladiators
                .OrderByDescending(p => p.GetWeaponPower())
                .FirstOrDefault();
        }

        public Gladiator GetGladitorWithHighestTotalPower()
        {
            return this.gladiators
                .OrderByDescending(p => p.GetTotalPower())
                .FirstOrDefault();
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.Count} gladiators are participating.";
        }
    }
}
