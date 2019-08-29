using System;
using System.Collections.Generic;
using System.Linq;

namespace P06.AutoRepairAndService
{
    class Program
    {
        static void Main()
        {
            string[] carModels = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Queue<string> queueCars = new Queue<string>(carModels);
            Stack<string> servedCars = new Stack<string>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] splittedInput = input.Split("-").ToArray();
                string command = splittedInput[0];

                switch (command)
                {
                    case "Service":
                        if (queueCars.Count != 0)
                        {
                            string currentModel = queueCars.Dequeue();
                            servedCars.Push(currentModel);
                            Console.WriteLine("Vehicle {0} got served.", currentModel);
                        }
                        break;

                    case "CarInfo":
                        string searchedModel = splittedInput[1];
                        if (queueCars.Contains(searchedModel))
                        {
                            Console.WriteLine("Still waiting for service.");
                        }
                        else if (servedCars.Contains(searchedModel))
                        {
                            Console.WriteLine("Served.");
                        }
                        break;

                    case "History":
                        Console.WriteLine(string.Join(", ", servedCars));
                        break;

                    default:
                        break;
                }
            }

            if (queueCars.Count != 0)
            {
                Console.Write("Vehicles for service: ");
                Console.WriteLine(string.Join(", ", queueCars));
            }

            if (servedCars.Count != 0)
            {
                Console.Write("Served vehicles: ");
                Console.WriteLine(string.Join(", ", servedCars));
            }
        }
    }
}
