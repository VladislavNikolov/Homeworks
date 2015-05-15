using System;

class PrintLongSequence
{
    static void Main()
    {
        for (int i = 0; i < 1000; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(i + 2 + ", ");
            }
            else
            {
                Console.Write((i * -1) - 2 + ", ");
            }
        }
    }
}

