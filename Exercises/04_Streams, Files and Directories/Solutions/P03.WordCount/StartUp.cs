namespace P03.WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string fileNameWords = "words.txt";
            string fileNameText = "text.txt";
            string fileNameActualResult = "actualResult.txt";
            string fileNameExpectedResult = "expectedResult.txt";
            string directory = "documents";

            string pathWordsFile = Path.Combine(directory, fileNameWords);
            string pathTextFile = Path.Combine(directory, fileNameText);
            string pathActualResultFile = Path.Combine(directory, fileNameActualResult);
            string pathExpectedResultFile = Path.Combine(directory, fileNameExpectedResult);

            string[] words = File.ReadAllLines(pathWordsFile);
            string[] textLines = File.ReadAllLines(pathTextFile);

            var wordsInfo = new Dictionary<string, int>();

            foreach (var word in words)
            {
                string currentWord = word.ToLower();

                if (!wordsInfo.ContainsKey(currentWord))
                {
                    wordsInfo.Add(currentWord, 0);
                }
            }

            foreach (var currentLine in textLines)
            {
                string[] currentLineWords = currentLine
                    .ToLower()
                    .Split(new char[] { ' ', '-', ',', '?', '!', '.', '\'' });

                foreach (var word in currentLineWords)
                {
                    if (wordsInfo.ContainsKey(word))
                    {
                        wordsInfo[word]++;
                    }
                }
            }

            File.Delete(pathActualResultFile);
            File.Delete(pathExpectedResultFile);

            foreach (var line in wordsInfo)
            {
                string currentLine = $"{line.Key} - {line.Value}{Environment.NewLine}";
                File.AppendAllText(pathActualResultFile, currentLine);
            }

            foreach (var line in wordsInfo.OrderByDescending(kvp => kvp.Value))
            {
                string currentLine = $"{line.Key} - {line.Value}{Environment.NewLine}";
                File.AppendAllText(pathExpectedResultFile, currentLine);
            }
        }
    }
}
