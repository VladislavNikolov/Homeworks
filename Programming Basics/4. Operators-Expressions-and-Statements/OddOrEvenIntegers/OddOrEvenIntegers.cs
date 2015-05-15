using System;

    class OddOrEvenIntegers
    {
        static void Main()
        {
            Console.WriteLine("Type in an integer:");
            int input = int.Parse(Console.ReadLine());

            if (input % 2 == 0)
            {
                Console.WriteLine("Your integer is even.");
            }
            else
            {
                Console.WriteLine("Your integer is odd.");
            }
        }
    }