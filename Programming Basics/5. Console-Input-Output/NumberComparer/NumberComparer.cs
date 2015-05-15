using System;

class NumberComparer
{
    static void Main()
    {
        Console.WriteLine("Enter two numbers:");
        double num1 = double.Parse(Console.ReadLine());
        double num2 = double.Parse(Console.ReadLine());
        Console.WriteLine(Math.Max(num1, num2));
    }
}