using System;

class FourDigitNumber
{
    static void Main()
    {
        Console.WriteLine("Type in a 4 digit number:");
        int input = int.Parse(Console.ReadLine());
        char[] allNums = input.ToString().ToCharArray();
        int sum = 0;

        for (int i = 0; i < 4; i++)
        {
            sum += input % 10;
            input /= 10;
        }

        Console.WriteLine("Sum of digits {0}", sum);
        Console.WriteLine("Reversed: {0}{1}{2}{3}", allNums[3], allNums[2], allNums[1], allNums[0]);
        Console.WriteLine("Last digit in front: {0}{1}{2}{3}", allNums[3], allNums[0], allNums[1], allNums[2]);
        Console.WriteLine("Exchange second and third: {0}{1}{2}{3}", allNums[0], allNums[2], allNums[1], allNums[3]);
    }
}