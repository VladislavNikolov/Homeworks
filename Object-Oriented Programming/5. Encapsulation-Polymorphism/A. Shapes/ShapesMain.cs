using System;

namespace A.Shapes
{
    class ShapesMain
    {
        public static void Main(string[] args)
        {
            Circle c1 = new Circle(3);
            BasicShape[] shapes = new BasicShape[]
            {
                new Rectangle(2, 4),
                new Triangle(5, 9)
            };

            foreach (BasicShape shape in shapes)
            {
                Console.WriteLine("{0} area is: {1}",shape.GetType().Name ,shape.CalculateArea());
                Console.WriteLine("{0} perimeter is: {1}",shape.GetType().Name, shape.CalculatePerimeter());               
            }

            Console.WriteLine("{0} area is: {1:F2}", c1.GetType().Name, c1.CalculateArea());
            Console.WriteLine("{0} perimeter is: {1:F2}", c1.GetType().Name, c1.CalculatePerimeter());
        }
    }
}