using System;
using System.Collections.Generic;

public class EnterNumbers
{
    public static void Main()
    {
        int start = 1;
        int end = 100;
        List<int> allNums = new List<int>();
        for (int i = 0; i < 10; i++)
        {
            start = ReadNumber(start, end);
            if (start == 0)
            {                
                break;
            }

            allNums.Add(start);
        }

        if (allNums.Count < 10)
        {
            Console.WriteLine("You done goofed up, foresight 0/20, you didn't get to 10 numbers.");
        }
        else
        {
            Console.WriteLine("You win! Your numbers are:{0}{1}", Environment.NewLine, string.Join(", ", allNums));
        }
    }

    private static int ReadNumber(int start, int end)
    {
        while (true)
        {
            try
            {   
                // If start and end are subsequent numbers you cannot enter a valid integer             
                if (start == end - 1)
                {
                    return 0;
                }

                int number = int.Parse(Console.ReadLine());

                if (number <= start || number >= end)
                {
                    throw new ArgumentOutOfRangeException("Number should be between start and end");
                }

                return number;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Invalid number");
            }
            catch (FormatException)
            {
                Console.WriteLine("Not a number");
            }
        }        
    }
}