using System;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;

class UppercaseWords
{
    static void Main()
    {
        string text = Console.ReadLine();

        Regex regex = new Regex(@"[a-zA-Z]+");
        while (text != "END")
        {
            MatchCollection matches = regex.Matches(text);
            string result = text;
            foreach (var match in matches)
            {
                string normal = match.ToString();
                if (IsAllUpper(normal))
                {
                    string reversed = ReverseString(normal);
                    if (normal == reversed)
                    {
                        string doubled = DoubleEachCharacter(normal);
                        string pattern = @"(?<![a-zA-Z])(" + normal + @")(?![a-zA-Z])";
                        result = Regex.Replace(result, pattern, doubled);
                    }
                    else
                    {
                        result = result.Replace(normal, reversed);
                    }
                }
            }
            result = SecurityElement.Escape(result);
            Console.WriteLine(result);
            text = Console.ReadLine();
        }
    }

    static bool IsAllUpper(string match)
    {
        for (int i = 0; i < match.Length; i++)
        {
            if (!Char.IsUpper(match[i]))
                return false;
        }

        return true;
    }

    static string ReverseString(string match)
    {
        char[] arr = match.ToCharArray();
        Array.Reverse(arr);
        string reversed = new string(arr);

        return reversed;
    }

    static string DoubleEachCharacter(string match)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < match.Length; i++)
        {
            sb.Append(match[i]);
            sb.Append(match[i]);
        }
        return sb.ToString();
    }
}