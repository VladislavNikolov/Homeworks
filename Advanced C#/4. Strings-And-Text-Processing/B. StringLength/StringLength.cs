using System;

class StringLength
{
    static void Main()
    {
        string inputLine = Console.ReadLine();

        //If less than 20 chars pad with stars
        if (inputLine.Length < 20)
        {
            inputLine = inputLine.PadRight(20, '*');//Padding with stars
        }

        string outputLine = inputLine.Substring(0, 20);//Getting only the first 20 chars
        Console.WriteLine(outputLine);
    }
}