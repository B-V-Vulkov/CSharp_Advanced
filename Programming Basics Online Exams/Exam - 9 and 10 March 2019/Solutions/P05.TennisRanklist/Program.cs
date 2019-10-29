using System;

namespace TennisRanklist
{
    class TennisRanklist
    {
        static void Main()
        {
            double tournaments = double.Parse(Console.ReadLine());
            int startPoints = int.Parse(Console.ReadLine());

            double win = 0;
            int sum = 0;

            for (int i = 1; i <= tournaments; i++)
            {
                string type = Console.ReadLine();
                if (type == "W")
                {
                    win++;
                    sum += 2000;
                }
                else if (type == "F")
                {
                    sum += 1200;
                }
                else if (type == "SF")
                {
                    sum += 720;
                }
            }
            Console.WriteLine("Final points: {0}", sum + startPoints);
            Console.WriteLine("Average points: {0}", Math.Floor(sum / tournaments));
            Console.WriteLine("{0:f2}%", (win / tournaments) * 100);
        }
    }
}
