using System;

namespace BasketballEquipment
{
    class BasketballEquipment
    {
        static void Main()
        {
            double charge = double.Parse(Console.ReadLine());

            double sneakers = charge * 0.6;
            double team = sneakers * 0.8;
            double ball = team / 4;
            double accessories = ball / 5;

            double sum = charge + sneakers + team + ball + accessories;
            Console.WriteLine("{0:f2}", sum);
        }
    }
}
