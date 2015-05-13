using System;

class ModifyBitAtGivenPosition
{
    static void Main()
    {
        Console.WriteLine("Type in an integer:");
        int input = int.Parse(Console.ReadLine());
        Console.WriteLine("Type in an index:");
        int index = int.Parse(Console.ReadLine());
        Console.WriteLine("Type in a bit value:");
        int bitValue = int.Parse(Console.ReadLine());

        int mask = 1 << index;
        if (bitValue == 0)
        {
            input &= ~mask;
            Console.WriteLine(input);
        }
        else
        {
            input |= mask;
            Console.WriteLine(input);
        }
    }
}