using System;
using System.Text.RegularExpressions;

class ReplaceAnchorTag
{
    static void Main()
    {
        string text = "<ul><li><a href=http://softuni.bg>SoftUni</a></li></ul>";

        string pattern = @"<a href=([^>]*)>([^<]*)</a>";
        string replacement = @"<URL href=$1>$2</URL>";
        Regex regex = new Regex(pattern);
        string result = regex.Replace(text, replacement);
        Console.WriteLine(result);
    }
}
