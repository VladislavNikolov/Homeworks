using System;

class ExtractBit3
{
    static void Main()
    {
        Console.WriteLine("Type in an integer:");
        int input = int.Parse(Console.ReadLine());
        int mask = 1;

        int bit = (input >> 3) & mask;
        Console.WriteLine(bit);
    }
}