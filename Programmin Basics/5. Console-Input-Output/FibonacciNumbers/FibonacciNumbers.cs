using System;

class FibonacciNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int fib1 = 0;
        int fib2 = 1;

        for (int i = 0; i < n; i++)
        {
            if (i == 0)
            {
                Console.Write(fib1 + " ");
            }
            else if (i == 1)
            {
                Console.Write(fib2 + " ");
            }
            else
            {
                int fib3 = fib1 + fib2;
                Console.Write(fib3 + " ");
                fib1 = fib2;
                fib2 = fib3;
            }
        }
        Console.WriteLine();
    }
}