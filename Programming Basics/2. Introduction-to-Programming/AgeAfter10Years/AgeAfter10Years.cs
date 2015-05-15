using System;

class AgeAfter10Years
{
    static void Main()
    {
        DateTime birthday = DateTime.Parse(Console.ReadLine());
        DateTime today = DateTime.Now;
        TimeSpan age = today.Subtract(birthday);
        Console.WriteLine(age);
        Console.WriteLine("{0} years", age.TotalDays / 365);

    }
}

