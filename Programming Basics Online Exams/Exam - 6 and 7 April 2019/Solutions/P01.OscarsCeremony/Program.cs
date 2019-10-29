using System;

namespace Oscarsceremony
{
    class Oscarsceremony
    {
        static void Main()
        {
            double rentHall = double.Parse(Console.ReadLine());

            double statues = rentHall * 0.70;
            double ketherin = statues * 0.85;
            double sound = ketherin * 0.5;

            double sum = rentHall + statues + ketherin + sound;

            Console.WriteLine("{0:F2}", sum);
        }
    }
}
