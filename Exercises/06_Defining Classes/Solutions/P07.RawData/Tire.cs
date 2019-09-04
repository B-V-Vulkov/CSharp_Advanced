namespace DefiningClasses
{
    public class Tire
    {
        private double pressure;
        private int age;

        public double Pressure
        {
            get { return this.pressure; }
        }

        public int Age
        {
            get { return this.age; }
        }

        public Tire(double pressure, int age)
        {
            this.pressure = pressure;
            this.age = age;
        }
    }
}
