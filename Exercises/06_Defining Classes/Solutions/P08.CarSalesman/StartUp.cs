namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int countEngines = int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>();
            Parking parking = new Parking();

            for (int i = 1; i <= countEngines; i++)
            {
                string[] engineInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = engineInfo[0];
                int power = int.Parse(engineInfo[1]);
                string displacement = "n/a";
                string efficiency = "n/a";

                if (engineInfo.Length >= 3)
                {
                    bool isDisplacement = int.TryParse(engineInfo[2], out int numberDisplacement);

                    if (isDisplacement)
                    {
                        displacement = numberDisplacement.ToString();
                    }
                    else
                    {
                        efficiency = engineInfo[2];
                    }
                }
                if (engineInfo.Length == 4)
                {
                    efficiency = engineInfo[3];
                }

                Engine engine = new Engine(model, power, displacement, efficiency);
                engines.Add(engine);
            }

            int countCars = int.Parse(Console.ReadLine());

            for (int i = 1; i <= countCars; i++)
            {
                string[] carInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = carInfo[0];
                string engineModel = carInfo[1];
                string weight = "n/a";
                string color = "n/a";

                if (carInfo.Length >= 3)
                {
                    bool isWeight = int.TryParse(carInfo[2], out int numberWeight);

                    if (isWeight)
                    {
                        weight = numberWeight.ToString();
                    }
                    else
                    {
                        color = carInfo[2];
                    }
                }

                if (carInfo.Length == 4)
                {
                    color = carInfo[3];
                }

                Engine engine = engines
                    .FirstOrDefault(x => x.Model == engineModel);

                Car car = new Car(model, engine, weight, color);

                parking.Add(car);
            }

            parking.Print();

        }
    }
}
