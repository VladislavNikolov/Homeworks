using System;

class CheckBitAtGivenPosition
{
    static void Main()
    {
        Console.WriteLine("Type in an integer:");
        int input = int.Parse(Console.ReadLine());
        Console.WriteLine("Type in an index:");
        int index = int.Parse(Console.ReadLine());

        int mask = 1;
        int bit = (input >> index) & mask;
        if (bit == 1)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}