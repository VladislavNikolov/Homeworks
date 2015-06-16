namespace B.InterestCalculator
{
    using System;

    public delegate decimal CalculateInterest(decimal sum, double interest, int years);

    public class InterestCalculatorMain
    {
        public static void Main(string[] args)
        {
            CalculateInterest type = GetSimpleInterest;
            InterestCalculator calc = new InterestCalculator(500, 0.056, 10, GetSimpleInterest);

            Console.WriteLine(calc);
        }

        public static decimal GetSimpleInterest(decimal sum, double interest, int years)
        {
            decimal result = sum * (decimal)(1 + (interest * years));

            return result;
        }

        public static decimal GetCompoundInterest(decimal sum, double interest, int years)
        {
            decimal result = sum * (decimal)Math.Pow((1 + (interest / 12)), years) * 12;

            return result;
        }
    }
}
