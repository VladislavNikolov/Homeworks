using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

class TextTransformer
{
    static void Main()
    {
        //Consolidate the lines
        string line = Console.ReadLine();
        StringBuilder sb = new StringBuilder();
        while (line != "burp")
        {
            sb.Append(line);
            line = Console.ReadLine();
        }

        //Remove white spaces
        string text = Regex.Replace(sb.ToString(), @"\s+", " ");

        //Get all the pieces
        string pattern = @"([\$\%\&\'])([^\s\$\%\&\']+?)\1";
        MatchCollection matches = Regex.Matches(text, pattern);

        //Decypher the pieces
        List<string> allStrings = new List<string>();
        foreach (Match match in matches)
        {
            sb.Clear();
            int weight = GetWeight(match.Groups[1].ToString());
            string sequence = match.Groups[2].ToString();
            for (int i = 0; i < sequence.Length; i++)
            {
                if (i % 2 == 0)
                {
                    char current = (char)(sequence[i] + weight);
                    sb.Append(current);
                }
                else
                {
                    char current = (char)(sequence[i] - weight);
                    sb.Append(current);
                }
            }
            allStrings.Add(sb.ToString());
        }
        Console.WriteLine(string.Join(" ", allStrings));
    }

    static int GetWeight(string symbol)
    {
        int weight = 0;
        switch (symbol)
        {
            case "$":
                weight = 1;
                break;
            case "%":
                weight = 2;
                break;
            case "&":
                weight = 3;
                break;
            case "'":
                weight = 4;
                break;
        }
        return weight;
    }
}