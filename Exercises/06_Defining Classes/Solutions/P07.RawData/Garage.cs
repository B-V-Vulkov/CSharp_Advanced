namespace DefiningClasses
{
    using System.Collections.Generic;
    using System.Linq;

    public class Garage
    {
        private List<Car> cars;

        public List<Car> Cars
        {
            get { return this.cars; }
            set { this.cars = value; }
        }

        public Garage()
        {
            cars = new List<Car>();
        }

        public void Add(Car car)
        {
            cars.Add(car);
        }

        public void Print(string command)
        {
            List<string> printCars = new List<string>();
            if (command == "fragile")
            {
                printCars = GetFragile();
            }
            else if (command == "flamable")
            {
                printCars = GetFlamable();
            }

            foreach (var car in printCars)
            {
                System.Console.WriteLine(car);
            }
        }

        private List<string> GetFragile()
        {
            List<string> printCars = cars
                .Where(c => c.Cargo.Type == "fragile")
                .Where(t => t.Tires.Any(p => p.Pressure < 1))
                .Select(m => m.Model)
                .ToList();

            return printCars;
        }

        private List<string> GetFlamable()
        {
            List<string> printCars = cars
                .Where(c => c.Cargo.Type == "flamable")
                .Where(e => e.Engine.Power > 250)
                .Select(m => m.Model)
                .ToList();

            return printCars;
        }
    }
}
