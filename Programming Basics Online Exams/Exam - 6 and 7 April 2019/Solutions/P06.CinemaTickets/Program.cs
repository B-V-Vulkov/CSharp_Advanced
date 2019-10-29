using System;

namespace CinemaTickets
{
    class CinemaTickets
    {
        static void Main()
        {
            int studentTicket = 0;
            int standardTicket = 0;
            int kidTicket = 0;
            double sum = 0;


            while (true)
            {
                string name = Console.ReadLine();
                if (name == "Finish")
                {
                    break;
                }

                int tikets = int.Parse(Console.ReadLine());

                for (int i = 1; i <= tikets; i++)
                {
                    string type = Console.ReadLine();

                    if (type == "End")
                    {
                        break;
                    }
                    else if (type == "student")
                    {
                        studentTicket++;
                    }
                    else if (type == "standard")
                    {
                        standardTicket++;
                    }
                    else
                    {
                        kidTicket++;
                    }
                    sum++;
                }

                Console.WriteLine("{0} - {1:f2}% full.", name, (sum / tikets) * 100);
                sum = 0;
            }
            double total = studentTicket + standardTicket + kidTicket;

            Console.WriteLine("Total tickets: {0}", total);
            Console.WriteLine("{0:f2}% student tickets.", (studentTicket / total) * 100);
            Console.WriteLine("{0:f2}% standard tickets.", (standardTicket / total) * 100);
            Console.WriteLine("{0:f2}% kids tickets.", (kidTicket / total) * 100);
        }
    }
}
