namespace HealthyHeaven
{
    public class Vegetable
    {
        public Vegetable(string name, int calories)
        {
            this.Name = name;
            this.Calories = calories;
        }

        public string Name { get; }

        public int Calories { get; }

        public override string ToString()
        {
            return $" - {this.Name} have {this.Calories} calories";
        }
    }
}
