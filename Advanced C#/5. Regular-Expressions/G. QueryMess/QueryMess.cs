using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class QueryMess
{
    static void Main()
    {
        string text = Console.ReadLine().Replace("%20", " ").Replace("+", " ");
        string questionsPattern = @".+(?=\?)\?";
        string emptySpacesPattern = @"\s{2,}";
        string keyValuePattern = @"(?:[\&\s]*)(?<key>[^[\=\s]+(?:[\s][^\=\s]+)*)(?:[\=\s]*)(?<value>[^\&\s]+(?:[\s][^\&\s]+)*)(?:[\s\&]*)";        
        Regex regex = new Regex(keyValuePattern);
        MatchCollection matches;
        var pairs = new Dictionary<string, List<string>>();
        while (text != "END")
        {
            text = Regex.Replace(text, questionsPattern, " ");
            text = Regex.Replace(text, emptySpacesPattern, " ");
            matches = regex.Matches(text);
            foreach (Match match in matches)
            {
                string key = match.Groups["key"].ToString();
                string value = match.Groups["value"].ToString();
                if (!pairs.ContainsKey(key))
                {
                    pairs.Add(key, new List<string>());
                }
                pairs[key].Add(value);
            }

            foreach (var pair in pairs)
            {
                Console.Write("{0}=[{1}]", pair.Key, string.Join(", ", pair.Value));
            }
            Console.WriteLine();

            pairs.Clear();
            text = Console.ReadLine().Replace("%20", " ").Replace("+", " ").Trim();
        }
    }
}