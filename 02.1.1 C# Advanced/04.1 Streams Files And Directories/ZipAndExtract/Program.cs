using System;
using System.IO.Compression;

namespace ZipAndExtract
{
    class Program
    {
        static void Main(string[] args)
        {
            ZipFile.CreateFromDirectory(@"C:\Users\rumen\source\repos\StreamsFilesAndDirectories\ZipAndExtract\originalFile", @"C:\Users\rumen\source\repos\StreamsFilesAndDirectories\ZipAndExtract\Archive.zip");

            ZipFile.ExtractToDirectory(@"C:\Users\rumen\source\repos\StreamsFilesAndDirectories\ZipAndExtract\Archive.zip", @"C:\Users\rumen\source\repos\StreamsFilesAndDirectories\ZipAndExtract");

        }
    }
}
