namespace HealthyHeaven
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Salad
    {
        private ICollection<Vegetable> products;

        public Salad(string name)
        {
            this.Name = name;
            this.products = new List<Vegetable>();
        }

        public string Name { get; }

        public int GetTotalCalories()
        {
            return this.products
                .Select(c => c.Calories)
                .Sum();
        }
        public int GetProductCount()
        {
            return this.products.Count();
        }

        public void Add(Vegetable product)
        {
            this.products.Add(product);
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"* Salad {this.Name} is {this.GetTotalCalories()} calories and have {this.GetProductCount()} products:");

            foreach (var vegetable in this.products)
            {
                stringBuilder.AppendLine(vegetable.ToString());
            }

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
