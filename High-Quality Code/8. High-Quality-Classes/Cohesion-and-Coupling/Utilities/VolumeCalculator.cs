namespace CohesionAndCoupling.Utilities
{
    using System;

    public static class VolumeCalculator
    {
        public static double CalculateRectangularVolume(double width, double height, double depth)
        {
            double volume = width * height * depth;

            return volume;
        }

        public static double CalculateCubiclVolume(double width)
        {
            double volume = width * width * width;

            return volume;
        }

        public static double CalculateCylindricalVolume(double baseRadius, double height)
        {
            double volume = Math.PI * baseRadius * baseRadius * height;

            return volume;
        }      
    }
}
