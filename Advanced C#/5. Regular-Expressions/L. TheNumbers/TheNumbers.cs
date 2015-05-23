using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class TheNumbers
{
    static void Main()
    {
        string text = Console.ReadLine();
        List<string> numbers = new List<string>();
        MatchCollection matches = Regex.Matches(text, @"\d+");
        foreach (Match match in matches)
        {
            int dec = int.Parse(match.ToString());
            string hex = "0x" + dec.ToString("X").PadLeft(4, '0');
            numbers.Add(hex);
        }
        Console.WriteLine(string.Join("-", numbers));
    }
}