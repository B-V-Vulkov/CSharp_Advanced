namespace P06.SongsQueue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            string[] sequenceOfSongs = Console.ReadLine()
                .Split(", ");

            Queue<string> songs = new Queue<string>(sequenceOfSongs);

            while (songs.Count != 0)
            {
                string command = Console.ReadLine();

                if (command.StartsWith("Add"))
                {
                    string song = command.Substring(4);

                    if (songs.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else
                    {
                        songs.Enqueue(song);
                    }
                }

                else if (command.StartsWith("Play"))
                {
                    songs.Dequeue();
                }

                else if (command.StartsWith("Show"))
                {
                    Queue<string> currentSongs = new Queue<string>(songs);
                    Console.WriteLine(string.Join(", ", currentSongs));
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}
