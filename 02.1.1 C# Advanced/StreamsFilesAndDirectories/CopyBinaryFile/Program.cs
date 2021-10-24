using System;
using System.IO;

namespace CopyBinaryFile
{
    class Program
    {
        static void Main(string[] args)
        {
            const int BYTE_BUFFER = 4096;
            
            using FileStream reader = new FileStream("copyMe.png", FileMode.Open); // FileAccess.Read
            using FileStream writer = new FileStream("../../../imageCopy.png", FileMode.Create); // FileAccess.Write

            while (reader.CanRead)
            {
                byte[] buffer = new byte[BYTE_BUFFER];
                int bytesRead = reader.Read(buffer, 0, buffer.Length);

                if (bytesRead == 0)
                {
                    break;
                }

                writer.Write(buffer, 0, bytesRead);
            }
        }
    }
}
