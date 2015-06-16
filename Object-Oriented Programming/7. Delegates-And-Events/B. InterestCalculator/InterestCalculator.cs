namespace B.InterestCalculator
{
    public class InterestCalculator
    {
        public InterestCalculator(decimal sum, double interest, int years, CalculateInterest interestType)
        {
            this.Sum = sum;
            this.Interest = interest;
            this.Years = years;
            this.InterestType = interestType;
        }

        public decimal Sum { get; set; }

        public double Interest { get; set; }

        public int Years { get; set; }

        public CalculateInterest InterestType { get; set; }
    }
}
