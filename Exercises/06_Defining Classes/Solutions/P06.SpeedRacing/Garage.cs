namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Garage
    {
        private List<Car> garage;

        public Garage()
        {
            garage = new List<Car>();
        }

        public void Add(Car car)
        {
            garage.Add(car);
        }

        public Car FindCar(string model)
        {
            return garage
                .FirstOrDefault(x => x.Model == model);
        }

        public void Print()
        {
            foreach (var currentCar in garage)
            {
                Console.WriteLine($"{currentCar.Model} {currentCar.FuelAmount:f2} {currentCar.TravelledDistance}");
            }
        }
    }
}
