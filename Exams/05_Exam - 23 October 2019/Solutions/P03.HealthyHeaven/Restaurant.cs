namespace HealthyHeaven
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Restaurant
    {
        private ICollection<Salad> data;

        public Restaurant(string name)
        {
            this.Name = name;
            this.data = new List<Salad>();
        }

        public string Name { get; }

        public void Add(Salad salad)
        {
            this.data.Add(salad);
        }

        public bool Buy(string name)
        {
            var salad = this.data
                .FirstOrDefault(n => n.Name == name);

            if (salad != null)
            {
                this.data.Remove(salad);
                return true;
            }
            return false;
        }

        public Salad GetHealthiestSalad()
        {
            return this.data
                .OrderBy(c => c.GetTotalCalories())
                .FirstOrDefault();
        }

        public string GenerateMenu()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"{this.Name} have {this.data.Count} salads:");

            foreach (var salad in this.data)
            {
                stringBuilder.AppendLine(salad.ToString());
            }

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
