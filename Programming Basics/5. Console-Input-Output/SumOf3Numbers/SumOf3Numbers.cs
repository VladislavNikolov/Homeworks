using System;

class SumOf3Numbers
{
    static void Main()
    {
        Console.WriteLine("Enter three numbers:");
        double sum = 0;
        for (int i = 0; i < 3; i++)
        {
            double num = double.Parse(Console.ReadLine());
            sum += num;
        }
        Console.WriteLine("The sum is {0}", sum);
    }
}