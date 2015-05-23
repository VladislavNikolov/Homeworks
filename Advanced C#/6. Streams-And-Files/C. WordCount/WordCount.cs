using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

class WordCount
{
    static void Main()
    {
        using (var readerOfWords = new StreamReader("words.txt"))
        {
            using (var readerOfText = new StreamReader("text.txt"))
            {
                using (var writer = new StreamWriter("results.txt"))
                {
                    var matches = new Dictionary<string, int>();
                    string text = readerOfText.ReadToEnd();//Get the entire text
                    string word;
                    while ((word = readerOfWords.ReadLine()) != null)
                    {
                        int count = 0;
                        string pattern = @"(?<![\w])" + word + @"(?![\w])";
                        //Count the matches of the word in the text, case-insensitive
                        foreach (Match match in Regex.Matches(text, pattern, RegexOptions.IgnoreCase))
                        {
                            count++;
                        }
                        //Add to dictionary
                        matches.Add(word, count);
                    }
                    //Sort by value in descending order nad print
                    foreach (var pair in matches.OrderByDescending(key => key.Value))
                    {
                        writer.WriteLine("{0} - {1}", pair.Key, pair.Value);
                        Console.WriteLine("{0} - {1}", pair.Key, pair.Value);
                    }
                    Console.WriteLine(@"Check ""C. WordCount\bin\Debug"" for results.txt");
                }
            }
        }
    }
}