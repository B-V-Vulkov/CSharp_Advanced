namespace P08.Threeuple
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string[] personInfo = Console.ReadLine()
                .Split(" ");

            string[] personBeerInfo = Console.ReadLine()
                .Split(" ");

            string[] bankInfo = Console.ReadLine()
                .Split(" ");

            string firstPersonName = $"{personInfo[0]} {personInfo[1]}";
            string firstPersonAddress = personInfo[2];
            string firstPersonTown = personInfo[3];

            bool seconPersonIsDrunk = false;

            if (personBeerInfo[2] == "drunk")
            {
                seconPersonIsDrunk = true;
            }

            string secondePersonName = personBeerInfo[0];
            double secondPersonLitersBeer = double.Parse(personBeerInfo[1]);

            string thirdPersonName = bankInfo[0];
            decimal thirdPersonAccount = decimal.Parse(bankInfo[1]);
            string thirdPersonBankName = bankInfo[2];

            var firstPersonThreeuple = 
                new Threeuple<string, string, string>(firstPersonName, firstPersonAddress, firstPersonTown);

            var secondPersonThreeuple =
                new Threeuple<string, double, bool>(secondePersonName, secondPersonLitersBeer, seconPersonIsDrunk);

            var thirdPersonThreeuple =
                new Threeuple<string, decimal, string>(thirdPersonName, thirdPersonAccount, thirdPersonBankName);

            Console.WriteLine(firstPersonThreeuple);
            Console.WriteLine(secondPersonThreeuple);
            Console.WriteLine($"{thirdPersonThreeuple.Item1} -> {thirdPersonThreeuple.Item2:f1} -> {thirdPersonThreeuple.Item3}");
        }
    }
}
