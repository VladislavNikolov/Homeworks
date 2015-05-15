using System;

class SumOf5Numbers
{
    static void Main()
    {
        string[] allNums = Console.ReadLine().Split(' ');
        double sum = 0;

        foreach (string number in allNums)
        {
            sum += Convert.ToDouble(number);
        }
        Console.WriteLine(sum);
    }
}