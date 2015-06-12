namespace A.Shapes
{
    public class Triangle : BasicShape
    {
        public Triangle(double width, double height) 
            : base(width, height)
        {
        }

        public override double CalculateArea()
        {
            return (this.Height * this.Width) / 2;
        }

        public override double CalculatePerimeter()
        {
            return this.Width * 3;
        }
    }
}