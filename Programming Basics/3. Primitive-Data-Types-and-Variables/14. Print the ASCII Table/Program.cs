using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i <= 255; i++)
        {
            Console.WriteLine("The character with code {0} is {1}", i, (char)i);
        }
    }
}

