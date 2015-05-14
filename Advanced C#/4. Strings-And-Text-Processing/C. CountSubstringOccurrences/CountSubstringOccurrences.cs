using System;

class CountSubstringOccurrences
{
    static void Main()
    {
        string text = Console.ReadLine().ToLower();//Input to lower to ignore character casing
        string word = Console.ReadLine().ToLower();//Input to lower to ignore character casing
        int counter = 0;
        int startIndex = 0;

        while (true)
        {
            int index = text.IndexOf(word, startIndex);//Find the index of the first occurance of "word"
            if (index > -1)//If it finds occurance
            {
                counter++;//+ one occurance
                startIndex = index + 1;//Set a new start index for the search so we don't get stuck in a loop
                if (startIndex == text.Length)//If the start index is equal to text.Length we would be out of bounds
                {
                    break;
                }
            }
            else//If it doesn't find occurance
            {
                break;
            }
        }
        Console.WriteLine(counter);
    }
}