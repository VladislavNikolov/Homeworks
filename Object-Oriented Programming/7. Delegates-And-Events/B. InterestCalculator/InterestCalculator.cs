namespace B.InterestCalculator
{
    using System;

    public class InterestCalculator
    {
        public InterestCalculator(decimal sum, double interest, int years, Func<decimal, double, int, decimal> calculateInterest)
        {
            this.Sum = sum;
            this.Interest = interest;
            this.Years = years;
            this.Total = calculateInterest(sum, interest, years);
        }

        public decimal Sum { get; set; }

        public double Interest { get; set; }

        public int Years { get; set; }

        public decimal Total { get; set; }
    }
}
