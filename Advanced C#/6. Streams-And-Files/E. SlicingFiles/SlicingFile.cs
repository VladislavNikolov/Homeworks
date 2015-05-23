using System;
using System.Collections.Generic;
using System.IO;

class SlicingFile
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
            "part-0" + extension,
            "part-1" + extension,
            "part-2" + extension,
            "part-3" + extension,
            "part-4" + extension
        }, "assembled " + sourceFile);

        Console.WriteLine(@"Check ""E. SlicingFile\bin\Debug"" for ""assembled {0}""", sourceFile);
    }

    private static void Slice(string sourceFile, string destinationDirectory, int parts)
    {
        using (var source = new FileStream(sourceFile, FileMode.Open))
        {
            byte[] buffer = new byte[4096];
            var allData = new List<byte>();
            while (true)
            {
                int readBytes = source.Read(buffer, 0, buffer.Length);
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
                var newFile = destinationDirectory + "part-" + i + extension;
                using (var copy = new FileStream(newFile, FileMode.Create))
                {
                    if (i == parts - 1)
                    {
                        copy.Write(allData.ToArray(), i * partSize, partSize + leftOver);
                    }
                    else
                    {
                        copy.Write(allData.ToArray(), i * partSize, partSize);
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
            using (var source = new FileStream(sourceFile, FileMode.Open))
            {
                byte[] buffer = new byte[4096];
                while (true)
                {
                    int readBytes = source.Read(buffer, 0, buffer.Length);
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

        using (var copy = new FileStream(destinationDirectory, FileMode.Create))
        {
            copy.Write(allData.ToArray(), 0, allData.Count);
        }
    }
}