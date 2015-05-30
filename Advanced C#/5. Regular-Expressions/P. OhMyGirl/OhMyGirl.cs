using System;
using System.Text;
using System.Text.RegularExpressions;

class OhMyGirl
{
    static void Main()
    {
        string key = Console.ReadLine();
        string text = Console.ReadLine();
        StringBuilder sb = new StringBuilder();
        while (text != "END")
        {
            sb.Append(text);
            text = Console.ReadLine();
        }
        text = sb.ToString();
        sb.Clear();

        //Build the pattern
        if (char.IsLetterOrDigit(key[0]))
        {
            sb.Append(key[0]);
        }
        else
        {
            sb.Append(@"\" + key[0]);
        }  
    
        for (int i = 1; i < key.Length - 1; i++)
        {
            if (char.IsLetter(key[i]))
            {
                if (char.IsUpper(key[i]))
                {
                    sb.Append("[A-Z]*");
                }
                else
                {
                    sb.Append("[a-z]*");
                }
            }
            else if (char.IsDigit(key[i]))
            {
                sb.Append(@"\d*");
            }
            else
            {
                sb.Append(@"\" + key[i]);
            }
        }

        if (char.IsLetterOrDigit(key[key.Length - 1]))
        {
            sb.Append(key[key.Length - 1]);
        }
        else
        {
            sb.Append(@"\" + key[key.Length - 1]);
        }

        string pattern = sb + "(.{2,6})" + sb;
        
        //Get the result
        MatchCollection matches = Regex.Matches(text, pattern);
        foreach (Match match in matches)
        {
            Console.Write(match.Groups[1]);
        }
        Console.WriteLine();
    }
}