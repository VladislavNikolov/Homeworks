using  System;
using System.Collections.Generic;

class Palindromes
{
    static void Main()
    {
        string[] allWords = Console.ReadLine().Split(new char[] 
        {' ', ',', '.', '?', '!'}, StringSplitOptions.RemoveEmptyEntries);
        SortedSet<string> palindromes = new SortedSet<string>();
        string firstHalf;
        string secondalf;

        for (int i = 0; i < allWords.Length; i++)
        {
            if (allWords[i].Length == 1)//If the word has only one letter add it to palindromes
            {
                palindromes.Add(allWords[i]);
            }
            else
            {
                firstHalf = allWords[i].Substring(0, allWords[i].Length/2);
                if (allWords[i].Length%2 == 0)//if the word has even number of characters
                {
                    secondalf = GetReversedString(allWords[i].Substring(allWords[i].Length/2));
                }
                else////if the word has odd number of characters
                {
                    secondalf = GetReversedString(allWords[i].Substring(allWords[i].Length / 2 + 1));
                }
                if (firstHalf == secondalf)//If both halves match add to palindromes
                {
                    palindromes.Add(allWords[i]);
                }
            }
        }
        Console.WriteLine(String.Join(", ", palindromes));
    }

    static string GetReversedString(string line)
    {
        char[] reversedChars = line.ToCharArray();
        Array.Reverse(reversedChars);
        string reversed = new string(reversedChars);

        return reversed;
    }
}