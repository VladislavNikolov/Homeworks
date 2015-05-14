using System;

class TextFilter
{
    static void Main()
    {
        string[] bannedWords = Console.ReadLine().Split(new char[] {',', ' '},
            StringSplitOptions.RemoveEmptyEntries);
        string text = Console.ReadLine();
        string censoredWord;
        int censoredWordLength;

        Console.WriteLine();//Better readability of the output
        for (int i = 0; i < bannedWords.Length; i++)
        {
            censoredWordLength = bannedWords[i].Length;//Get the length of the word to censor
            censoredWord = new string('*', censoredWordLength);//Create the new censored word with '*'
            text = text.Replace(bannedWords[i], censoredWord);//Replace the banned word with censored word in text
        }
        Console.WriteLine(text);
    }
}
