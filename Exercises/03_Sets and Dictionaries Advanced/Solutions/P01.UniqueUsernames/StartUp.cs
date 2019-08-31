namespace P01.UniqueUsernames
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            int countOfUsernames = int.Parse(Console.ReadLine());

            HashSet<string> users = new HashSet<string>();

            for (int user = 1; user <= countOfUsernames; user++)
            {
                string userName = Console.ReadLine();

                users.Add(userName);
            }

            foreach (var user in users)
            {
                Console.WriteLine(user);
            }
        }
    }
}
