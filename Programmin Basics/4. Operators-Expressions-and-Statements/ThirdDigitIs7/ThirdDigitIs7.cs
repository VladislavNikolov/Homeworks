using System;

    class ThirdDigitIs7
    {
        static void Main()
        {
            Console.WriteLine("Type in an integer:");
            int input = int.Parse(Console.ReadLine());

            input /= 100;
            int numCheck = input % 10;

            if (numCheck == 7)
            {
                Console.WriteLine("Third digit is 7.");
            }
            else
            {
                Console.WriteLine("Third digit is not 7.");
            }
        }
    }