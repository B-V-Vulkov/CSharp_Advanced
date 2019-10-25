namespace Heroes
{
    using System.Text;

    public class Item
    {
        public Item(int strength, int ability, int intelligence)
        {
            this.Strength = strength;
            this.Ability = ability;
            this.Intelligence = intelligence;
        }

        public int Strength { get; }

        public int Ability { get; }

        public int Intelligence { get; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"  * Strength: {this.Strength}");
            stringBuilder.AppendLine($"  * Ability: {this.Ability}");
            stringBuilder.AppendLine($"  * Intelligence: {this.Intelligence}");

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
