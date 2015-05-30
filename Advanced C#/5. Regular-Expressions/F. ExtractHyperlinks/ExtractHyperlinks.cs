using System;
using System.Text;
using System.Text.RegularExpressions;

class ExtractHyperlinks
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        string line = Console.ReadLine();

        while (line != "END")
        {
            sb.Append(line);
            line = Console.ReadLine();
        }

        string text = sb.ToString();

        Regex rgx = new Regex(@"<a\s+(?:[^>]+\s+)?href\s*=\s*(?:'([^']*)'|""([^""]*)""|([^\s>]+))[^>]*>");
        Match match = rgx.Match(text);

        while (match != Match.Empty)
        {
            for (int i = 1; i < match.Groups.Count; i++)
            {
                if (match.Groups[i].Value != String.Empty)
                {
                    Console.WriteLine(match.Groups[i].Value);
                }
            }

            match = match.NextMatch();
        }
    }
}