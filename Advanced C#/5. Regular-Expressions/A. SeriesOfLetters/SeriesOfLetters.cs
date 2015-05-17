using System;
using System.Text.RegularExpressions;

class SeriesOfLetters
{
    static void Main()
    {
        string text = Console.ReadLine();
        for (int i = 0; i < text.Length; i++)
        {
            string pattern = "" + text[i] + "{2,}";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(text);
            if (match.Success)
            {
                text = text.Replace(match.ToString(), text[i].ToString());
            }
        }
        Console.WriteLine(text);
    }
}