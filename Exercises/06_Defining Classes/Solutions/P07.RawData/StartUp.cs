namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            int countCars = int.Parse(Console.ReadLine());

            Garage garage = new Garage();

            for (int i = 1; i <= countCars; i++)
            {
                string[] carInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = carInfo[0];
                int engineSpeed = int.Parse(carInfo[1]);
                int enginePower = int.Parse(carInfo[2]);
                int cargoWeight = int.Parse(carInfo[3]);
                string cargoType = carInfo[4];
                double tire1Pressure = double.Parse(carInfo[5]);
                int tire1Age = int.Parse(carInfo[6]);
                double tire2Pressure = double.Parse(carInfo[7]);
                int tire2Age = int.Parse(carInfo[8]);
                double tire3Pressure = double.Parse(carInfo[9]);
                int tire3Age = int.Parse(carInfo[10]);
                double tire4Pressure = double.Parse(carInfo[11]);
                int tire4Age = int.Parse(carInfo[12]);

                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoWeight, cargoType);

                Tire tire1 = new Tire(tire1Pressure, tire1Age);
                Tire tire2 = new Tire(tire2Pressure, tire2Age);
                Tire tire3 = new Tire(tire3Pressure, tire3Age);
                Tire tire4 = new Tire(tire4Pressure, tire4Age);
                List<Tire> tires = new List<Tire>();

                tires.Add(tire1);
                tires.Add(tire2);
                tires.Add(tire3);
                tires.Add(tire4);

                Car car = new Car(model, engine, cargo, tires);
                garage.Add(car);
            }

            string command = Console.ReadLine();
            garage.Print(command);
        }
    }
}
