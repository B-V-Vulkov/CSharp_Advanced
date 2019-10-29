using System;

namespace MovieRatings
{
    class MovieRatings
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            string bestMove = string.Empty;
            string bedMove = string.Empty;
            double bestRating = double.MinValue;
            double bedRaiting = double.MaxValue;
            double sumRaiting = 0;

            for (int i = 1; i <= number; i++)
            {
                string name = Console.ReadLine();
                double rating = double.Parse(Console.ReadLine());

                if (rating > bestRating)
                {
                    bestRating = rating;
                    bestMove = name;
                }
                if (rating < bedRaiting)
                {
                    bedRaiting = rating;
                    bedMove = name;
                }

                sumRaiting = sumRaiting + rating;
            }

            Console.WriteLine("{0} is with highest rating: {1:f1}", bestMove, bestRating);
            Console.WriteLine("{0} is with lowest rating: {1:f1}", bedMove, bedRaiting);
            Console.WriteLine("Average rating: {0:f1}", sumRaiting / number);
        }
    }
}
