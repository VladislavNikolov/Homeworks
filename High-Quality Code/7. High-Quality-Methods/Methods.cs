using System;

namespace Methods
{
    internal class Methods
    {
        static double CalculateTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("The side must be a positive number.");
            }

            double semiPerimeter = (a + b + c) / 2;
            double area = Math.Sqrt(
                semiPerimeter * (semiPerimeter - a) * (semiPerimeter - b) * (semiPerimeter - c));
            
            return area;
        }

        static string ConvertNumberToWord(int number)
        {
            switch (number)
            {
                case 0: 
                    return "zero";
                case 1: 
                    return "one";
                case 2: 
                    return "two";
                case 3: 
                    return "three";
                case 4: 
                    return "four";
                case 5: 
                    return "five";
                case 6: 
                    return "six";
                case 7: 
                    return "seven";
                case 8: 
                    return "eight";
                case 9:
                    return "nine";
            }

            return "Invalid number!";
        }

        static int FindMax(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentException("There must be at least one element.");
            }

            int maxValue = elements[0];
            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > maxValue)
                {
                    maxValue = elements[i];
                }
            }

            return maxValue;
        }

        private static void PrintAsFixedPointNumber(object number)
        {
            Console.WriteLine("{0:f2}", number);
        }

        static void PrintAsPercentageNumber(object number)
        {
            Console.WriteLine("{0:p0}", number);
        }

        static void PrintAsRoundTripNumber(object number)
        {
            Console.WriteLine("{0,8}", number);
        }

        static double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));

            return distance;
        }

        static bool AreVertical(double x1, double x2)
        {
            bool areVertical = (x1 == x2);

            return areVertical;
        }

        static bool AreHorizontal(double y1, double y2)
        {
            bool areHorizontal = (y1 == y2);

            return areHorizontal;
        }

        static void Main()
        {
            Console.WriteLine(CalculateTriangleArea(3, 4, 5));
            
            Console.WriteLine(ConvertNumberToWord(5));
            
            Console.WriteLine(FindMax(5, -1, 3, 2, 14, 2, 3));
            
            PrintAsFixedPointNumber(1.3);
            PrintAsPercentageNumber(0.75);
            PrintAsRoundTripNumber(2.30);

            Console.WriteLine(CalculateDistance(3, -1, 3, 2.5));
            Console.WriteLine("Horizontal? " + AreHorizontal(-1, 2.5));
            Console.WriteLine("Vertical? " + AreVertical(3, 3));

            Student peter = new Student() { FirstName = "Peter", LastName = "Ivanov" };
            peter.OtherInfo = "From Sofia, born at 17.03.1992";

            Student stella = new Student() { FirstName = "Stella", LastName = "Markova" };
            stella.OtherInfo = "From Vidin, gamer, high results, born at 03.11.1993";

            Console.WriteLine("{0} older than {1} -> {2}",
                peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
