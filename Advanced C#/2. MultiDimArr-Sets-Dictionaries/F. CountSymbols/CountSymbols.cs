using System;
using System.Collections.Generic;

class CountSymbols
{
    static void Main()
    {
        char[] text = Console.ReadLine().ToCharArray();
        var allSymbols = new SortedDictionary<char, int>();

        for (int i = 0; i < text.Length; i++)
        {
            if (allSymbols.ContainsKey(text[i]))
            {
                allSymbols[text[i]] += 1;
            }
            else
            {
                allSymbols.Add(text[i], 1);
            }
        }

        foreach (var pair in allSymbols)
        {
            Console.WriteLine("{0}: {1} time/s", pair.Key, pair.Value);
        }
    }
}
