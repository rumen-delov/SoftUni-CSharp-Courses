using System;

namespace ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            // Option 1

            // Read the path to a file
            string filePath = Console.ReadLine();

            int pathSeparatorIndex = filePath.LastIndexOf('\\');
            int extensionSeparatorIndex = filePath.LastIndexOf('.');

            int fileNameStartIndex = pathSeparatorIndex + 1;
            int fileNameLength = extensionSeparatorIndex - pathSeparatorIndex - 1;

            int extensionStartIndex = extensionSeparatorIndex + 1;

            // subtract the file name and its extension
            string fileName = filePath.Substring(fileNameStartIndex, fileNameLength);
            string fileExtension = filePath.Substring(extensionStartIndex);



            // Option 2

            // Read the path to a file

            //string[] filePath = Console.ReadLine()
            //    .Split('\\', StringSplitOptions.RemoveEmptyEntries);

            //int lastArrayIndex = filePath.Length - 1;
            //string lastArrayElement = filePath[lastArrayIndex];

            // subtract the file name and its extension
            //int separatorIndex = lastArrayElement.IndexOf('.');

            //string fileName = lastArrayElement.Substring(0, separatorIndex);
            //string fileExtension = lastArrayElement.Substring(separatorIndex + 1);



            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}
