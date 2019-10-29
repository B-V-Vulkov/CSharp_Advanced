using System;

namespace GameNumberWars
{
    class GameNumberWars
    {
        static void Main()
        {
            string name1 = Console.ReadLine();
            string name2 = Console.ReadLine();

            int points1 = 0;
            int points2 = 0;

            string command = string.Empty;

            while (true)
            {
                command = Console.ReadLine();
                if (command == "End of game")
                {
                    Console.WriteLine("{0} has {1} points", name1, points1);
                    Console.WriteLine("{0} has {1} points", name2, points2);
                    break;
                }
                int card1 = int.Parse(command);
                command = Console.ReadLine();
                int card2 = int.Parse(command);

                if (card1 > card2)
                {
                    points1 += Math.Abs(card1 - card2);
                }
                else if (card2 > card1)
                {
                    points2 += Math.Abs(card1 - card2);
                }
                else
                {
                    Console.WriteLine("Number wars!");
                    command = Console.ReadLine();
                    card1 = int.Parse(command);
                    command = Console.ReadLine();
                    card2 = int.Parse(command);
                    if (card1 > card2)
                    {
                        Console.WriteLine("{0} is winner with {1} points", name1, points1);
                    }
                    else
                    {
                        Console.WriteLine("{0} is winner with {1} points", name2, points2);
                    }
                    break;
                }
            }
        }
    }
}
