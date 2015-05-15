using System;

class LettersChangeNumbers
{
    static void Main()
    {
        string[] allWords = Console.ReadLine().Split((char[]) null, StringSplitOptions.RemoveEmptyEntries);
        decimal currentNum, currentChar;
        decimal sum = 0;

        for (int i = 0; i < allWords.Length; i++)
        {
            currentNum = decimal.Parse(allWords[i].Substring(1, allWords[i].Length - 2));
            
            if (char.IsUpper(allWords[i][0]))
            {
                currentChar = allWords[i][0] - '@';
                currentNum /= currentChar;
            }
            else
            {
                currentChar = allWords[i][0] - '`';
                currentNum *= currentChar;
            }
            if (char.IsUpper(allWords[i][allWords[i].Length - 1]))
            {
                currentChar = allWords[i][allWords[i].Length - 1] - '@';
                currentNum -= currentChar;
            }
            else
            {
                currentChar = allWords[i][allWords[i].Length - 1] - '`';
                currentNum += currentChar;
            }
            sum += currentNum;
        }
        Console.WriteLine("{0:F2}", sum);
    }
}
