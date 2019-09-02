namespace P04.CopyBinaryFile
{
    using System;
    using System.IO;

    public class StartUp
    {
        public static void Main()
        {
            string filePic = "copyMe.png";
            string filePicCopy = "copyMe-Copy.png";
            string directory = "documents";
            string pathPic = Path.Combine(directory, filePic);
            string pathPicCopy = Path.Combine(directory, filePicCopy);

            using (FileStream streamReader = new  FileStream(pathPic, FileMode.Open))
            {
                using (FileStream streamWriter = new FileStream(pathPicCopy, FileMode.Create))
                {
                    while (true)
                    {
                        byte[] byteArray = new byte[4096];
                        int size = streamReader.Read(byteArray, 0, byteArray.Length);

                        if (size == 0)
                        {
                            break;
                        }

                        streamWriter.Write(byteArray, 0, size);
                    }
                }
            }
        }
    }
}
