using System;

namespace CinemaVoucher
{
    class CinemaVoucher
    {
        static void Main()
        {
            double valcher = double.Parse(Console.ReadLine());
            double price = 0;
            int counter1 = 0;
            int counter2 = 0;


            while (true)
            {
                string comand = Console.ReadLine();
                if (comand == "End")
                {
                    break;
                }
                else if (comand.Length > 8)
                {
                    char first = comand.ToCharArray()[0];
                    int firstPrice = (int)first;
                    char second = comand.ToCharArray()[1];
                    int secondPrice = (int)second;
                    price = price + firstPrice + secondPrice;
                    if (valcher < price)
                    {
                        break;
                    }
                    counter1++;
                }
                else
                {
                    char first = comand.ToCharArray()[0];
                    int firstPrice = (int)first;
                    price = price + firstPrice;
                    if (valcher < price)
                    {
                        break;
                    }
                    counter2++;
                }
            }

            Console.WriteLine(counter1);
            Console.WriteLine(counter2);
        }
    }
}
