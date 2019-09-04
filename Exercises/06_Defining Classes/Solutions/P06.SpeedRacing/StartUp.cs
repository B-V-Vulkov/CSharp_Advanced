namespace DefiningClasses
{
    using System;

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

                string carModel = carInfo[0];
                double carFuelAmount = double.Parse(carInfo[1]);
                double carFuelConsumptionPerKilometer = double.Parse(carInfo[2]);

                Car currentCar = new Car(carModel, carFuelAmount, carFuelConsumptionPerKilometer);
                garage.Add(currentCar);
            }

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] splittedInput = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = splittedInput[1];
                double distance = double.Parse(splittedInput[2]);

                Car currentCar = garage.FindCar(model);

                if (currentCar.CanMove(distance))
                {
                    currentCar.Move(distance);
                }
                else
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
            }

            garage.Print();
        }
    }
}
