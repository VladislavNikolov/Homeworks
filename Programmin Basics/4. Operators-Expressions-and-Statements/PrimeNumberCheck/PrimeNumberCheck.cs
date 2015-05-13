using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.WriteLine("Type in an integer:");
        int input = int.Parse(Console.ReadLine());
        bool prime = true;

        for (int i = 2; i <= input; i++)
        {
            if (input % i == 0 && i != input)
            {
                prime = false;
            }
        }

        if (input == 0 || input == 1 || !prime)
        {
            Console.WriteLine("Not a prime number");
        }
        else
        {
            Console.WriteLine("Prime number");
        }
    }
}

