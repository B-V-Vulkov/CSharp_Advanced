namespace P01.ListyIterator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            var elements = Console.ReadLine()
                .Split(' ')
                .Skip(1)
                .ToList();

            var listyIterator = new ListyIterator<string>(elements);

            string command = String.Empty;

            while ((command = Console.ReadLine()) != "END")
            {
                if (command == "Move")
                {
                    Console.WriteLine(listyIterator.Move());
                }
                else if (command == "HasNext")
                {
                    Console.WriteLine(listyIterator.HasNext());
                }
                else if (command == "Print")
                {
                    try
                    {
                        listyIterator.Print();
                    }
                    catch (InvalidOperationException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }
    }
}
