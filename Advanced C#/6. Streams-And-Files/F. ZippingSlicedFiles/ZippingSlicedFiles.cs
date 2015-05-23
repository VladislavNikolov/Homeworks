using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;

class ZippingSlicedFiles
{
    static void Main()
    {
        string sourceFile = "image.jpg";
        string destinationDirectory = "";
        int parts = 5;
        int startIndex = sourceFile.LastIndexOf(".");
        string extension = sourceFile.Substring(startIndex);
        Slice(sourceFile, destinationDirectory, parts);
        Assemble(new List<string>()
        {
            "part-0.gz",
            "part-1.gz",
            "part-2.gz",
            "part-3.gz",
            "part-4.gz"
        }, "assembled " + sourceFile);

        Console.WriteLine(@"Check ""F. ZippingSlicedFiles\bin\Debug"" for ""assembled {0}""", sourceFile);
    }

    private static void Slice(string sourceFile, string destinationDirectory, int parts)
    {
        using (var inputStream = new FileStream(sourceFile, FileMode.Open))
        {
            byte[] buffer = new byte[4096];
            var allData = new List<byte>();
            while (true)
            {
                int readBytes = inputStream.Read(buffer, 0, buffer.Length);
                if (readBytes == 0)
                {
                    break;
                }

                for (int i = 0; i < readBytes; i++)
                {
                    allData.Add(buffer[i]);
                }
            }

            int partSize = allData.Count / parts;
            int leftOver = allData.Count - partSize * parts;
            int startIndex = sourceFile.LastIndexOf(".");
            string extension = sourceFile.Substring(startIndex);
            for (int i = 0; i < parts; i++)
            {
                var newFile = destinationDirectory + "part-" + i + ".gz";
                using (var outputStream = new FileStream(newFile, FileMode.Create))
                {
                    using (var compressionStream = new GZipStream(outputStream, CompressionMode.Compress, false))
                    {
                        if (i == parts - 1)
                        {
                            compressionStream.Write(allData.ToArray(), i * partSize, partSize + leftOver);
                        }
                        else
                        {
                            compressionStream.Write(allData.ToArray(), i * partSize, partSize);
                        }
                    }                  
                }
            }
        }
    }

    private static void Assemble(List<string> files, string destinationDirectory)
    {
        var allData = new List<byte>();
        for (int i = 0; i < files.Count; i++)
        {
            var sourceFile = files[i];
            using (var inputStream = new FileStream(sourceFile, FileMode.Open))
            {
                using (var decompressionStream = new GZipStream(inputStream, CompressionMode.Decompress, false))
                {
                    byte[] buffer = new byte[4096];
                    while (true)
                    {
                        int readBytes = decompressionStream.Read(buffer, 0, buffer.Length);
                        if (readBytes == 0)
                        {
                            break;
                        }

                        for (int j = 0; j < readBytes; j++)
                        {
                            allData.Add(buffer[j]);
                        }
                    }
                }
            }
        }

        using (var outputStream = new FileStream(destinationDirectory, FileMode.Create))
        {
            outputStream.Write(allData.ToArray(), 0, allData.Count);
        }
    }
}