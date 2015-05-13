using System;

class PointCircleRectangle
{
    static void Main()
    {
        Console.WriteLine("Type in the x value:");
        double x1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Type in the y value:");
        double y1 = double.Parse(Console.ReadLine());
        bool inCircle = true;
        bool inRectangle = false;

        double radiusPow2 = 1.5 * 1.5;
        double distancePow2 = Math.Pow((x1 - 1), 2) + Math.Pow((y1 - 1), 2);

        //Check if point is inside the circle
        if (distancePow2 > radiusPow2)
        {
            inCircle = false;
        }

        //Check if point is inside the rectangle
        if (x1 >= -1 && x1 <= 5 && y1 >= -1 && y1 <= 1)
        {
            inRectangle = true;
        }

        if (inCircle && !inRectangle)
        {
            Console.WriteLine("The point is inside the circle and outside of the rectangle.");
        }
        else
        {
            Console.WriteLine("The point is either outside the circle or inside of the rectangle or both.");
        }
    }
}