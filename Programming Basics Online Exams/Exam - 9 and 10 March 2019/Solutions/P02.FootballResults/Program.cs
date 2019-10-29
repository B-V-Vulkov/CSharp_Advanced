using System;

namespace FootballResults
{
    class FootballResults
    {
        static void Main()
        {
            int teamWon = 0;
            int teamLost = 0;
            int drawnDames = 0;


            for (int i = 1; i <= 3; i++)
            {
                string raiting = Console.ReadLine();
                int team1 = int.Parse(raiting[0].ToString());
                int team2 = int.Parse(raiting[2].ToString());
                if (team1 > team2)
                {
                    teamWon++;
                }
                else if (team2 > team1)
                {
                    teamLost++;
                }
                else
                {
                    drawnDames++;
                }
            }
            Console.WriteLine("Team won {0} games.", teamWon);
            Console.WriteLine("Team lost {0} games.", teamLost);
            Console.WriteLine("Drawn games: {0}", drawnDames);
        }
    }
}
