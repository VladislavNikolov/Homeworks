using System;

class BiggerNumber
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());

        int max = GetMax(firstNumber, secondNumber);
        Console.WriteLine(max);
    }

    static int GetMax(int num1, int num2)
    {
        if (num1 > num2)
        {
            return num1;
        }
        else
        {
            return num2;
        }
    }
}