namespace CohesionAndCoupling.Utilities
{
    using System;

    public static class DistanceCalculator
    {
        private const double DefaultX1 = 0;
        private const double DefaultY1 = 0;
        private const double DefaultZ1 = 0;

        public static double CalcDistance2D(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));

            return distance;
        }

        public static double CalcDistance3D(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            double distance = 
                Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)) + ((z2 - z1) * (z2 - z1)));

            return distance;
        }

        public static double CalcDiagonalXYZ(double x2, double y2, double z2)
        {
            double distance = CalcDistance3D(
                DefaultX1, DefaultY1, DefaultZ1, x2, y2, z2);

            return distance;
        }

        public static double CalcDiagonalXY(double x2, double y2)
        {
            double distance = CalcDistance2D(DefaultX1, DefaultY1, x2, y2);

            return distance;
        }

        public static double CalcDiagonalXZ(double x2, double y2)
        {
            double distance = CalcDistance2D(DefaultX1, DefaultY1, x2, y2);

            return distance;
        }

        public static double CalcDiagonalYZ(double x2, double y2)
        {
            double distance = CalcDistance2D(DefaultX1, DefaultY1, x2, y2);

            return distance;
        }
    }
}
