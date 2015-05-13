using System;

class FormattingNumbers
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        Console.Write("|{0,-10} |{1:F10}|{2,10:0.##}|{3,-10:0.###}|", 
            a.ToString("X"), Convert.ToString(a, 2).PadLeft(10, '0'), b, c);
    }
}