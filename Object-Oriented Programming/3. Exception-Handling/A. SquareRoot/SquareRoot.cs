using System;

public class SquareRoot
{
    public static void Main()
    {
        Console.WriteLine("Enter a positive integer:");
        string readLine = Console.ReadLine();
        try
        {
            int number = int.Parse(readLine);
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException("Number cannot be negative");
            }

            Console.WriteLine("The square root of {0} is {1}", number, Math.Sqrt(number));
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Invalid number");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number");
        }
        finally
        {
            Console.WriteLine("Good bye");
        }
    }
}