namespace P06.ZipAndExtract
{
    using System;
    using System.IO;
    using System.IO.Compression;

    public class StartUp
    {
        public static void Main()
        {
            string file = "copyMe.png";
            string zipFile = "myZipFile.zip";
            string directory = "documents";
            string pathFile = Path.Combine(directory, file);
            string pathZipFile = Path.Combine(BackToDirectory(3), zipFile);

            using (var archive = ZipFile.Open(pathZipFile, ZipArchiveMode.Create))
            {
                archive.CreateEntryFromFile(pathFile, Path.GetFileName(file));
            }
        }
        private static string BackToDirectory(int directory)
        {
            string currentDirectory = Environment.CurrentDirectory;

            for (int i = 0; i < directory; i++)
            {
                currentDirectory = Directory.GetParent(currentDirectory).ToString();
            }

            return currentDirectory;
        }
    }
}
