namespace Heroes
{
    using System.Text;

    public class Hero
    {
        public Hero(string name, int level, Item item)
        {
            this.Name = name;
            this.Level = level;
            this.Item = item;
        }

        public string Name { get; }

        public int Level { get; }

        public Item Item { get; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Hero: {this.Name} - {this.Level}lvl");
            stringBuilder.AppendLine($"Item:");
            stringBuilder.AppendLine($"{this.Item.ToString()}");

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
