using System;

class PointInCircle
{
    static void Main()
    {
        Console.WriteLine("Type in the x value:");
        double x1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Type in the y value:");
        double y1 = double.Parse(Console.ReadLine());
        double radiusPow2 = 2 * 2;

        double distancePow2 = Math.Pow(x1, 2) + Math.Pow(y1, 2);

        if (distancePow2 < radiusPow2)
        {
            Console.WriteLine("The point is inside the circle.");
        }
        else if (distancePow2 == radiusPow2)
        {
            Console.WriteLine("The point is on the cirlce");
        }
        else
        {
            Console.WriteLine("The point is outside the circle.");
        }
    }
}