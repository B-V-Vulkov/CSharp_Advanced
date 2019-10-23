namespace P01.TrojanInvasion
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int waves = int.Parse(Console.ReadLine());

            var platesInput = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var plates = new Queue<int>(platesInput);
            var warriors = new Stack<int>();

            for (int i = 1; i <= waves; i++)
            {
                var warriorsInput = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

                warriors = new Stack<int>(warriorsInput);

                if (i % 3 == 0)
                {
                    var extraPlatesInput = Console.ReadLine()
                        .Split(' ')
                        .Select(int.Parse)
                        .ToList();

                    foreach (var plate in extraPlatesInput)
                    {
                        plates.Enqueue(plate);
                    }
                }

                while (plates.Count != 0 && warriors.Count != 0)
                {
                    int result = plates.Dequeue() - warriors.Pop();

                    if (result > 0)
                    {
                        var currentPlates = new Queue<int>();
                        currentPlates.Enqueue(result);

                        foreach (var plate in plates)
                        {
                            currentPlates.Enqueue(plate);
                        }

                        plates = currentPlates;
                    }
                    else if (result < 0)
                    {
                        warriors.Push(Math.Abs(result));
                    }
                }

                if (plates.Count == 0)
                {
                    break;
                }
            }

            if (plates.Count != 0)
            {
                Console.WriteLine("The Spartans successfully repulsed the Trojan attack.");
                Console.Write("Plates left: ");
                Console.Write(string.Join(", ", plates));
            }
            else
            {
                Console.WriteLine("The Trojans successfully destroyed the Spartan defense.");
                Console.Write("Warriors left: ");
                Console.Write(string.Join(", ", warriors));
            }
        }
    }
}
