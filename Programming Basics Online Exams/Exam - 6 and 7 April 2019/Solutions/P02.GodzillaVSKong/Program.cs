using System;

namespace GodzillaKong
{
    class GodzillaKong
    {
        static void Main()
        {
            double budgetMovie = double.Parse(Console.ReadLine());
            double numberStats = double.Parse(Console.ReadLine());
            double priceClothing = double.Parse(Console.ReadLine());

            double priceDecor = budgetMovie * 0.1;
            double sumPriceClothing = numberStats * priceClothing;
            if (numberStats > 150)
            {
                sumPriceClothing = sumPriceClothing * 0.9;
            }

            double totaSum = sumPriceClothing + priceDecor;

            if (budgetMovie >= totaSum)
            {
                Console.WriteLine("Action!");
                Console.WriteLine("Wingard starts filming with {0:f2} leva left.", budgetMovie - totaSum);
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine("Wingard needs {0:f2} leva more.", totaSum - budgetMovie);
            }
        }
    }
}
