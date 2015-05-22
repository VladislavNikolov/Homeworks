using System;
using System.ComponentModel;
using System.IO;

class LineNumbers
{
    static void Main()
    {
        using (var reader = new StreamReader("Input.txt"))
        {
            using (var writer = new StreamWriter("Output.txt"))
            {
                string line;
                int counter = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    line = "" + counter + "." + line;
                    writer.WriteLine(line);
                    counter++;
                }
            }
        }
        Console.WriteLine(@"Check ""..\..\B. LineNumbers\bin\Debug"" for Output.txt");
    }
}