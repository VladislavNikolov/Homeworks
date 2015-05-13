using System;

class Trapezoids
{
    static void Main()
    {
        Console.WriteLine("Type in the value of side a:");
        double sideA = double.Parse(Console.ReadLine());
        Console.WriteLine("Type in the value of side b:");
        double sideB = double.Parse(Console.ReadLine());
        Console.WriteLine("Type in the value of the height:");
        double height = double.Parse(Console.ReadLine());

        double area = ((sideA + sideB) / 2) * height;
        Console.WriteLine("The area is {0}", area);
    }
}