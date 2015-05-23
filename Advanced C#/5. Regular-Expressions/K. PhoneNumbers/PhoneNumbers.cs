using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

class PhoneNumbers
{
    static void Main()
    {
        string text = Console.ReadLine();
        string pattern = @"(?<name>[A-Z][a-zA-Z]*)(?!(?:[^\+\d]*[A-Z]))(?:[^\+\d]*)(?<phone>[\+\d]*(?:[\(\)\/\.\-\s]*\d)*)";
        var phonebook = new Dictionary<string, string>();
        while (text != "END")
        {
            MatchCollection matches = Regex.Matches(text, pattern);
            foreach (Match match in matches)
            {
                string name = match.Groups["name"].ToString();
                string phone = match.Groups["phone"].ToString();
                StringBuilder sb = new StringBuilder();
                foreach (char ch in phone)
                {
                    if (char.IsNumber(ch) || ch == '+')
                    {
                        sb.Append(ch);
                    }
                }
                if (sb.Length > 1)
                {
                    phonebook.Add(name, sb.ToString());
                }
            }
            text = Console.ReadLine();
        }

        if (phonebook.Count == 0)
        {
            Console.WriteLine("<p>No matches!</p>");
        }
        else
        {
            Console.Write("<ol>");
            foreach (var pair in phonebook)
            {
                Console.Write("<li><b>{0}:</b> {1}</li>", pair.Key, pair.Value);
            }
            Console.Write("</ol>");
            Console.WriteLine();
        }
    }
}