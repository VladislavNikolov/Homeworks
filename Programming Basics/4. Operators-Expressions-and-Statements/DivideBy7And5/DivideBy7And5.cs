using System;

class DivideBy7And5
{
    static void Main()
    {
        Console.WriteLine("Type in your intgeger:");
        int input = int.Parse(Console.ReadLine());

        if (input % 7 == 0 && input % 5 == 0)
        {
            Console.WriteLine("Your integer is both divisible by 7 and 5.");
        }
        else
        {
            Console.WriteLine("Your integer is not both divisible by 7 and 5.");
        }
    }
}