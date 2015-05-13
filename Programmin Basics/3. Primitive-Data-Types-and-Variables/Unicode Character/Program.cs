using System;

/*
 * Declare a character variable and assign it with the symbol that has Unicode code 42 (decimal) using the \u00XX syntax, and then print it.
 */

namespace Unicode_Character
{
    class Program
    {
        static void Main(string[] args)
        {
            char uni = '\u002A';

            Console.WriteLine(uni);
        }
    }
}
