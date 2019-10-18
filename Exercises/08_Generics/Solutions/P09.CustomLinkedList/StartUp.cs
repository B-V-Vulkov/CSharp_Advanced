using System.Threading.Channels;

namespace CustomList
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            //Checking the constructors
            var customList1 = new CustomList<int>();

            var customList2 = new CustomList<string>(10);

            var list = new List<char> {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I'};
            var customList3 = new CustomList<char>(list);

            //Checking Add method
            customList1.Add(1);
            customList2.Add("Text");
            customList3.Add('J');

            //Checking RemoveAt method
            Console.WriteLine(customList1.RemoveAt(0)); //Return 1
            //Console.WriteLine(customList1.RemoveAt(0));   //Return ArgumentOutOfRangeException

            //Checking Remove method
            Console.WriteLine(customList2.Remove("Text")); //Return True
            Console.WriteLine(customList2.Remove("Text")); //Return False

            //Checking IndexOf method
            Console.WriteLine(customList3.IndexOf('A')); //Return 0
            Console.WriteLine(customList3.IndexOf('Z')); //Return -1

            //Checking Contains method
            Console.WriteLine(customList3.Contains('A')); //Return True
            Console.WriteLine(customList3.Contains('Z')); //Return False

            //Checking Insert method
            Console.WriteLine(string.Join(", ", customList3));  //Return A, B, C, D, E, F, G, H, I, J
            customList3.Insert(3, 'Z');
            Console.WriteLine(string.Join(", ", customList3));  //Return A, B, C, Z, D, E, F, G, H, I, J

            //Checking Swap method
            Console.WriteLine(string.Join(", ", customList3));  //Return A, B, C, Z, D, E, F, G, H, I, J
            customList3.Swap(0, 1);
            Console.WriteLine(string.Join(", ", customList3));  //Return B, A, C, Z, D, E, F, G, H, I, J

            //Checking Clear method
            customList3.Clear();
            Console.WriteLine(customList3.Count); //Return 0
        }
    }
}
