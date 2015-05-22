using System;
using System.IO;

class CopyBinaryFile
{
    static void Main()
    {
        FileStream inputStream = new FileStream("image.jpg", FileMode.Open);
        FileStream outputStream = new FileStream("imageCopy.jpg", FileMode.Create);

        byte[] buffer = new byte[4096];
        while (true)
        {
            int readBytes = inputStream.Read(buffer, 0, buffer.Length);
            if (readBytes == 0)
            {
                break;
            }
            outputStream.Write(buffer, 0, readBytes);
        }
        Console.WriteLine(@"Check ""..\..\D. CopyBinaryFile\bin\Debug"" for imageCopy.jpg");
        inputStream.Close();
        outputStream.Close();
    }
}