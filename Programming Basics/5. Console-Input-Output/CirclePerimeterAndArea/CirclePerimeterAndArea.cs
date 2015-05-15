using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.WriteLine("Enter radius:");
        double radius = double.Parse(Console.ReadLine());

        double perimeter = Math.PI * 2 * radius;
        double area = Math.PI * Math.Pow(radius, 2);
        Console.WriteLine("The perimeter is: {0:F2}", perimeter);
        Console.WriteLine("The area is: {0:F2}", area);
    }
}