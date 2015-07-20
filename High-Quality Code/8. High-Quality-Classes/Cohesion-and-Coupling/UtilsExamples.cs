namespace CohesionAndCoupling
{
    using System;
    using Utilities;

    public class UtilsExamples
    {
        public static void Main()
        {
            Console.WriteLine(ExtensionMethods.GetFileExtension("example"));
            Console.WriteLine(ExtensionMethods.GetFileExtension("example.pdf"));
            Console.WriteLine(ExtensionMethods.GetFileExtension("example.new.pdf"));

            Console.WriteLine(ExtensionMethods.GetFileNameWithoutExtension("example"));
            Console.WriteLine(ExtensionMethods.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(ExtensionMethods.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine(
                "Distance in the 2D space = {0:f2}", 
                DistanceCalculator.CalcDistance2D(1, -2, 3, 4));
            Console.WriteLine(
                "Distance in the 3D space = {0:f2}",
                DistanceCalculator.CalcDistance3D(5, 2, -1, 3, -6, 4));
          
            Console.WriteLine("Volume = {0:f2}", VolumeCalculator.CalculateRectangularVolume(3, 4, 5));
            Console.WriteLine("Diagonal XYZ = {0:f2}", DistanceCalculator.CalcDiagonalXYZ(3, 4, 5));
            Console.WriteLine("Diagonal XY = {0:f2}", DistanceCalculator.CalcDiagonalXY(3, 4));
            Console.WriteLine("Diagonal XZ = {0:f2}", DistanceCalculator.CalcDiagonalXZ(3, 4));
            Console.WriteLine("Diagonal YZ = {0:f2}", DistanceCalculator.CalcDiagonalYZ(3, 4));
        }
    }
}
