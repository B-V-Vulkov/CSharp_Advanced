namespace P01.EvenLines
{
    using System;
    using System.IO;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string fileName = "text.txt";
            string directory = "documents";
            string filePath = Path.Combine(directory, fileName);

            string currentLine = string.Empty;
            string result = string.Empty;
            int counter = 0;

            using (StreamReader streamReader = new StreamReader(filePath))
            {
                currentLine = streamReader.ReadLine();

                while (currentLine != null)
                {
                    if (counter % 2 == 0)
                    {
                        result = ReplaceSymbols(currentLine);
                        result = ReverseWords(currentLine);
                        Console.WriteLine(result);
                    }

                    counter++;
                    currentLine = streamReader.ReadLine();
                }
            }
        }

        private static string ReplaceSymbols(string input)
        {
            return input.Replace('-', '@')
                .Replace(',', '@')
                .Replace('.', '@')
                .Replace('!', '@')
                .Replace('?', '@');
        }

        private static string ReverseWords(string input)
        {
            string[] result = input.Split(" ");
            return string.Join(" ", result.Reverse());
        }
    }
}
