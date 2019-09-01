namespace P02.LineNumbers
{
    using System;
    using System.IO;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string fileInputName = "input.txt";
            string fileOutputName = "output.txt";
            string directory = "documents";

            string fileInputPath = Path.Combine(directory, fileInputName);
            string fileOutputPath = Path.Combine(directory, fileOutputName);

            string[] textLines = File.ReadAllLines(fileInputPath);

            int lettersCount = 0;
            int punctuationCount = 0;
            int counter = 1;

            foreach (var line in textLines)
            {
                lettersCount = line.Count(char.IsLetter);
                punctuationCount = line.Count(char.IsPunctuation);

                string result = $"Line {counter++}: {line} ({lettersCount})({punctuationCount}){Environment.NewLine}";
                File.AppendAllText(fileOutputPath, result);
            }
        }
    }
}
