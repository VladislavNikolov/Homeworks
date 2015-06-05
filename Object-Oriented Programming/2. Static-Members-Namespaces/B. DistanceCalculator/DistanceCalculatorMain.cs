using System;

public class DistanceCalculatorMain
{
    public static void Main()
    {
        Point3D a = new Point3D(2, 5, 9);
        Point3D b = new Point3D(8, -1, 4);

        double distance = DistanceCalculator.CalculateDistance(a, b);
        Console.WriteLine("The distance is: {0}", distance);
    }
}