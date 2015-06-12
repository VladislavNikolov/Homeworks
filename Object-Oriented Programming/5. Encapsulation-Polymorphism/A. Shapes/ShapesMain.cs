using System;

namespace A.Shapes
{
    public class ShapesMain
    {
        public static void Main(string[] args)
        {
            IShape[] shapes = 
            {
                new Rectangle(2, 4),
                new Triangle(5, 9),
                new Circle(3)
            };

            foreach (IShape shape in shapes)
            {
                Console.WriteLine("{0} area is: {1:F2}",shape.GetType().Name ,shape.CalculateArea());
                Console.WriteLine("{0} perimeter is: {1:F2}",shape.GetType().Name, shape.CalculatePerimeter());               
            }
        }
    }
}