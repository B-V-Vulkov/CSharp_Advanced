using System;

namespace OscarsCinema
{
    class OscarsCinema
    {
        static void Main()
        {
            string movie = Console.ReadLine();
            string hall = Console.ReadLine();
            int numTickets = int.Parse(Console.ReadLine());
            double tickets = 0;

            switch (movie)
            {
                case "A Star Is Born":
                    {
                        if (hall == "normal")
                        {
                            tickets = 7.50;
                        }
                        else if (hall == "luxury")
                        {
                            tickets = 10.50;
                        }
                        else
                        {
                            tickets = 13.50;
                        }
                        break;
                    }
                case "Bohemian Rhapsody":
                    {
                        if (hall == "normal")
                        {
                            tickets = 7.35;
                        }
                        else if (hall == "luxury")
                        {
                            tickets = 9.45;
                        }
                        else
                        {
                            tickets = 12.75;
                        }
                        break;
                    }
                case "Green Book":
                    {
                        if (hall == "normal")
                        {
                            tickets = 8.15;
                        }
                        else if (hall == "luxury")
                        {
                            tickets = 10.25;
                        }
                        else
                        {
                            tickets = 13.25;
                        }
                        break;
                    }
                case "The Favourite":
                    {
                        if (hall == "normal")
                        {
                            tickets = 8.75;
                        }
                        else if (hall == "luxury")
                        {
                            tickets = 11.55;
                        }
                        else
                        {
                            tickets = 13.95;
                        }
                        break;
                    }
            }

            double total = tickets * numTickets;

            Console.WriteLine("{0} -> {1:f2} lv.", movie, total);
        }
    }
}
