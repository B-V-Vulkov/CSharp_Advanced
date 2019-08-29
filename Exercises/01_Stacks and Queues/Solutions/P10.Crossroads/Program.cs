using System;
using System.Collections.Generic;
using System.Linq;

namespace P10.Crossroads
{
    class Program
    {
        static void Main()
        {
            int greenLightDuration = int.Parse(Console.ReadLine());
            int freeWindowDuration = int.Parse(Console.ReadLine());

            Queue<string> queueOfCars = new Queue<string>();

            string command = string.Empty;
            bool isHitted = false;
            int totalCars = 0;
            string hittedCar = string.Empty;
            char characterHit = '\0';


            while ((command = Console.ReadLine()) != "END")
            {
                if (command != "green")
                {
                    queueOfCars.Enqueue(command);
                    continue;
                }

                int currentGreenLightDuration = greenLightDuration;

                while (currentGreenLightDuration > 0 && queueOfCars.Count != 0)
                {
                    string currentCar = queueOfCars.Dequeue();
                    int carLenght = currentCar.Length;

                    if (currentGreenLightDuration - carLenght >= 0)
                    {
                        totalCars++;
                        currentGreenLightDuration -= carLenght;
                    }
                    else
                    {
                        currentGreenLightDuration += freeWindowDuration;

                        if (currentGreenLightDuration - carLenght >= 0)
                        {
                            totalCars++;
                            break;
                            
                        }
                        else
                        {
                            isHitted = true;
                            hittedCar = currentCar;
                            characterHit = currentCar[currentGreenLightDuration];
                            break;
                        }
                    }
                }

                if (isHitted)
                {
                    break;
                }
            }

            if (isHitted)
            {
                Console.WriteLine("A crash happened!");
                Console.WriteLine("{0} was hit at {1}.", hittedCar, characterHit);
            }
            else
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine("{0} total cars passed the crossroads.", totalCars);
            }
        }
    }
}
