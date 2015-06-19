namespace B.InterestCalculator
{
    using System;

    public class InterestCalculatorMain
    {
        public static void Main(string[] args)
        {
            Func<decimal, double, int, decimal> simple = GetSimpleInterest;
            Func<decimal, double, int, decimal> compound = GetCompoundInterest;

            var interest1 = new InterestCalculator(200, 5.6, 5, simple);
            var interest2 = new InterestCalculator(500, 7.2, 2, compound);

            Console.WriteLine("{0:F4}", interest1.Total);
            Console.WriteLine("{0:F4}", interest2.Total);
        }

        public static decimal GetSimpleInterest(decimal sum, double interest, int years)
        {
            decimal result = sum * (decimal)(1 + ((interest / 100) * years));

            return result;
        }

        public static decimal GetCompoundInterest(decimal sum, double interest, int years)
        {
            decimal result = sum * (decimal)Math.Pow((1 + ((interest / 100) / 12)), years) * 12;

            return result;
        }
    }
}
