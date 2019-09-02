namespace P05.DirectoryTraversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string[] fileArray = Directory.GetFiles(".", "*.*");
            DirectoryInfo directoryInfo = new DirectoryInfo(".");
            FileInfo[] fileInfos = directoryInfo.GetFiles();

            var dirInfo = new Dictionary<string, Dictionary<string, double>>();

            foreach (var currentFile in fileInfos)
            {
                double size = currentFile.Length / 1024d;
                string fileName = currentFile.Name;
                string extension = currentFile.Extension;

                if (!dirInfo.ContainsKey(extension))
                {
                    dirInfo.Add(extension, new Dictionary<string, double>());
                }
                if (!dirInfo[extension].ContainsKey(fileName))
                {
                    dirInfo[extension].Add(fileName, size);
                }
            }

            var sortedDictionary = dirInfo
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, y => y.Value);

            string pathDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string report = "report.txt";
            string pathReport = Path.Combine(pathDesktop, report);

            File.Delete(pathReport);

            foreach (var (extension, value) in sortedDictionary)
            {
                string print = extension + Environment.NewLine;

                File.AppendAllText(pathReport, print);

                foreach (var (fileName, size) in value)
                {
                    print = $"{fileName} {Math.Round(size, 2)}kb" + Environment.NewLine;
                    File.AppendAllText(pathReport, print);
                }
            }
        }
    }
}
