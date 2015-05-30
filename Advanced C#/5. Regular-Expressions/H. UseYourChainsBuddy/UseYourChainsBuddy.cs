using System;
using System.Text;
using System.Text.RegularExpressions;

class UseYourChainsBuddy
{
    static void Main()
    {
        string text = Console.ReadLine();
        StringBuilder sb = new StringBuilder();
        MatchCollection matches = Regex.Matches(text, @"<p>(.+?)<\/p>");
        foreach (Match match in matches)
        {
            string clearChars = Regex.Replace(match.Groups[1].ToString(), @"[^a-z\d]+", @" ");
            char[] allChars = Regex.Replace(clearChars, @"\s+", @" ").ToCharArray();
            for (int i = 0; i < allChars.Length; i++)
            {
                if (allChars[i] >= 97 && allChars[i] <= 109)
                {
                    allChars[i] += (char)13;
                }
                else if (allChars[i] >= 110 && allChars[i] <= 122)
                {
                    allChars[i] -= (char)13;
                }
            }
            sb.Append(new string(allChars));
        }
        Console.WriteLine(sb.ToString());
    }
}