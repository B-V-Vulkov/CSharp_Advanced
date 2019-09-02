namespace P02.LineNumbers
{
    using System;
    using System.IO;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string fileNameText = "text.txt";
            string fileNameOutput = "output.txt";
            string directory = "documents";

            string pathTextFile = Path.Combine(directory, fileNameText);
            string pathOutputFile = Path.Combine(directory, fileNameOutput);

            string[] textLines = File.ReadAllLines(pathTextFile);

            int lettersCount = 0;
            int punctuationCount = 0;
            int counter = 1;

            File.Delete(pathOutputFile);

            foreach (var line in textLines)
            {
                lettersCount = line.Count(char.IsLetter);
                punctuationCount = line.Count(char.IsPunctuation);

                string result = $"Line {counter++}: {line} ({lettersCount})({punctuationCount}){Environment.NewLine}";
                File.AppendAllText(pathOutputFile, result);
            }
        }
    }
}
