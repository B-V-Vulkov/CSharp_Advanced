namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Parking
    {
        private List<Car> cars;

        public Parking()
        {
            cars = new List<Car>();
        }

        public void Add(Car car)
        {
            cars.Add(car);
        }

        public void Print()
        {
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($"  {car.Engine.Model}:");
                Console.WriteLine($"    Power: {car.Engine.Power}");
                Console.WriteLine($"    Displacement: {car.Engine.Displacement}");
                Console.WriteLine($"    Efficiency: {car.Engine.Efficiency}");
                Console.WriteLine($"  Weight: {car.Weight}");
                Console.WriteLine($"  Color: {car.Color}");
            }
        }
    }
}
