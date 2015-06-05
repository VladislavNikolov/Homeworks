using System;

public static class DistanceCalculator
{
    public static double CalculateDistance(Point3D a, Point3D b)
    {
        double result = 
            Math.Sqrt(((b.X - a.X) * (b.X - a.X)) + ((b.Y - a.Y) * (b.Y - a.Y)) + ((b.Z - a.Z) * (b.Z - a.Z)));

        return result;
    }
}