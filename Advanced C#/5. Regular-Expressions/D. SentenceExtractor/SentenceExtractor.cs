using System;
using System.Text.RegularExpressions;

class SentenceExtractor
{
    static void Main()
    {
        string word = Console.ReadLine();
        string text = Console.ReadLine();

        string pattern = @"(?<=\s|^)(.*?\b" + word + @"\b.*?(?=\!|\.|\?)[?.!])";
        Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
        MatchCollection matches = regex.Matches(text);

        foreach (var match in matches)
        {
            Console.WriteLine(match);
        }
    }
}
