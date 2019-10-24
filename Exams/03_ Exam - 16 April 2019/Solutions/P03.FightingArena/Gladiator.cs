namespace FightingArena
{
    using System.Text;

    public class Gladiator
    {
        public Gladiator(string name, Stat stat, Weapon weapon)
        {
            this.Name = name;
            this.Stat = stat;
            this.Weapon = weapon;
        }

        public string Name { get; }

        public Stat Stat { get; }

        public Weapon Weapon { get; }

        public int GetWeaponPower()
        {
            return this.Weapon.Size +
                this.Weapon.Solidity +
                this.Weapon.Sharpness;
        }

        public int GetStatPower()
        {
            return this.Stat.Strength +
                this.Stat.Flexibility +
                this.Stat.Agility +
                this.Stat.Skills +
                this.Stat.Intelligence;
        }

        public int GetTotalPower()
        {
            return this.GetWeaponPower() + this.GetStatPower();
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"{this.Name} - {this.GetTotalPower()}");
            stringBuilder.AppendLine($"  Weapon Power: {this.GetWeaponPower()}");
            stringBuilder.AppendLine($"  Stat Power: {this.GetStatPower()}");

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
