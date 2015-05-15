using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        Console.WriteLine("Type in an integer:");
        int input = int.Parse(Console.ReadLine());
        Console.WriteLine("Type in an index:");
        int index = int.Parse(Console.ReadLine());
        
        int mask = 1;
        int bit = (input >> index) & mask;
        Console.WriteLine(bit);
    }
}