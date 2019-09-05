namespace DefiningClasses
{
    public class Car
    {
        private string model;
        private Engine engine;
        private string weight;
        private string color;

        public string Model
        {
            get { return this.model; }
        }

        public Engine Engine
        {
            get { return this.engine; }
        }

        public string Weight
        {
            get { return this.weight; }
        }

        public string Color
        {
            get { return this.color; }
        }

        public Car(string model, Engine engine)
        {
            this.model = model;
            this.engine = engine;
            this.weight = "n/a";
            this.color = "n/a";
        }

        public Car(string model, Engine engine, string weight)
            : this(model, engine)
        {
            this.weight = weight;
        }

        public Car(string model, Engine engine, string weight, string color)
            : this(model, engine, weight)
        {
            this.color = color;
        }
    }
}
