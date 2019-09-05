namespace DefiningClasses
{
    public class Engine
    {
        private string model;
        private int power;
        private string displacement;
        private string efficiency;

        public string Model
        {
            get { return this.model; }
        }

        public int Power
        {
            get { return this.power; }
        }

        public string Displacement
        {
            get { return this.displacement; }
        }

        public string Efficiency
        {
            get { return this.efficiency; }
        }

        public Engine(string model, int power)
        {
            this.model = model;
            this.power = power;
            this.displacement = "n/a";
            this.efficiency = "n/a";
        }

        public Engine(string model, int power, string displacement)
            : this(model, power)
        {
            this.displacement = displacement;
        }

        public Engine(string model, int power, string displacement, string efficiency)
            : this(model, power, displacement)
        {
            this.efficiency = efficiency;
        }
    }
}
