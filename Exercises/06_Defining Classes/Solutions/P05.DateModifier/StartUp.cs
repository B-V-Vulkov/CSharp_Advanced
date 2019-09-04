namespace DefiningClasses
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string firsDate = Console.ReadLine();
            string secondDate = Console.ReadLine();

            DateModifier date = new DateModifier(firsDate, secondDate);

            Console.WriteLine(date.DaysBetween());
        }
    }
}
