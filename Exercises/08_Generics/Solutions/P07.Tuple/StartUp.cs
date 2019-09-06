namespace P07.Tuple
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string[] personInfo = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string[] personBeerInfo = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string[] numbersInfo = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string personName = personInfo[0] + " " + personInfo[1];
            string persnTown = string.Empty;

            for (int i = 2; i < personInfo.Length; i++)
            {
                persnTown += personInfo[i] + " ";
            }

            string personBeerName = personBeerInfo[0];
            double amountOfBeer = double.Parse(personBeerInfo[1]);

            int myInteger = int.Parse(numbersInfo[0]);
            double myDouble = double.Parse(numbersInfo[1]); 

            Tuple<string, string> personTuple =
                new Tuple<string, string>(personName, persnTown);

            Tuple<string, double> personBeerTuple =
                new Tuple<string, double>(personBeerName, amountOfBeer);

            Tuple<int, double> numbersTuple =
                new Tuple<int, double>(myInteger, myDouble);

            Console.WriteLine(personTuple.GetInfo());
            Console.WriteLine(personBeerTuple.GetInfo());
            Console.WriteLine(numbersTuple.GetInfo());
        }
    }
}
