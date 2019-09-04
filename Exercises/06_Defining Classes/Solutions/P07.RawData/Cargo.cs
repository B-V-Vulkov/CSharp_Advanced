namespace DefiningClasses
{
    public class Cargo
    {
        private int weight;
        private string type;

        public int Weight
        {
            get { return this.weight; }
        }

        public string Type
        {
            get { return this.type; }
        }

        public Cargo(int weight, string type)
        {
            this.weight = weight;
            this.type = type;
        }
    }
}
