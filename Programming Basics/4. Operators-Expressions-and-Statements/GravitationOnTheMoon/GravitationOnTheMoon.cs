using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        Console.WriteLine("Type in your weight:");
        decimal weight = decimal.Parse(Console.ReadLine());

        weight *= 0.17M;
        Console.WriteLine("Your weight on the moon would be {0}", weight);
    }
}