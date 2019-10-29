using System;

namespace Gymnastics
{
    class Gymnastics
    {
        static void Main()
        {
            string country = Console.ReadLine();
            string appliance = Console.ReadLine();
            double points = 0;

            switch (country)
            {
                case "Russia":
                    {
                        if (appliance == "ribbon")
                        {
                            points = 18.5;
                        }
                        else if (appliance == "hoop")
                        {
                            points = 19.1;
                        }
                        else if (appliance == "rope")
                        {
                            points = 18.6;
                        }
                        break;
                    }
                case "Bulgaria":
                    {
                        if (appliance == "ribbon")
                        {
                            points = 19;
                        }
                        else if (appliance == "hoop")
                        {
                            points = 19.3;
                        }
                        else if (appliance == "rope")
                        {
                            points = 18.9;
                        }
                        break;
                    }
                case "Italy":
                    {
                        if (appliance == "ribbon")
                        {
                            points = 18.7;
                        }
                        else if (appliance == "hoop")
                        {
                            points = 18.8;
                        }
                        else if (appliance == "rope")
                        {
                            points = 18.85;
                        }
                        break;
                    }
            }
            double p = (points / 20) * 100;

            Console.WriteLine("The team of {0} get {1:f3} on {2}.", country, points, appliance);
            Console.WriteLine("{0:f2}%", 100 - p);
        }
    }
}
