using System;

public class Point3DMain
{
    public static void Main()
    {
        var p1 = new Point3D(1, -2, 5);
        var p2 = Point3D.StartingPoint;

        Console.WriteLine(p1);
        Console.WriteLine(p2);
    }
}