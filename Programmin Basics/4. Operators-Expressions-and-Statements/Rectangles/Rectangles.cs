using System;

class Rectangles
{
    static void Main()
    {
        Console.WriteLine("Type in a width:");
        double width = double.Parse(Console.ReadLine());
        Console.WriteLine("Type in a height:");
        double height = double.Parse(Console.ReadLine());

        double perimeter = 2 * width + 2 * height;
        double area = width * height;
        Console.WriteLine("Rectangle's perimeter is {0}", perimeter);
        Console.WriteLine("Rectangle's area is {0}", area);
    }
}