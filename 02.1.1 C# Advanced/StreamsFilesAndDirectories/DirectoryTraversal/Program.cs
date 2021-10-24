using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DirectoryTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<FileInfo>> filesByExtension = new Dictionary<string, List<FileInfo>>();

            string path = Console.ReadLine();
            string[] files = Directory.GetFiles(path);

            foreach (var file in files)
            {
                FileInfo info = new FileInfo(file);
                string extension = info.Extension;

                if (!filesByExtension.ContainsKey(extension))
                {
                    filesByExtension[extension] = new List<FileInfo>();
                }

                filesByExtension[extension].Add(info);
            }

            using StreamWriter writer = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/report.txt");

            foreach (var element in filesByExtension.OrderByDescending(f => f.Value.Count).ThenBy(f => f.Key))
            {
                writer.WriteLine(element.Key);

                foreach (var fileInfo in element.Value.OrderBy(f => Math.Ceiling((double)f.Length / 1024)))
                {
                    writer.WriteLine($"--{fileInfo.Name} - {Math.Ceiling((double)fileInfo.Length / 1024)}kb");
                }
            }
        }
    }
}
