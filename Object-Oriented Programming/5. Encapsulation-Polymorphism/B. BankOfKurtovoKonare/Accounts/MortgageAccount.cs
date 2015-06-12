namespace B.BankOfKurtovoKonare.Accounts
{
    using Customers;

    class MortgageAccount : Account
    {
        public MortgageAccount(Customer customer, decimal balance, decimal interestRate) 
            : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(int months)
        {
            if (this.Customer == Customer.Individual)
            {
                if (months > 6)
                {
                    return base.CalculateInterest(months - 6);
                }

                return this.Balance;
            }

            // (this.Customer == Customer.Company)
            if (months <= 12)
            {
                return this.Balance * (1 + (((this.InterestRate / 2) * months) / 100));
            }

            var firstTwelveMonthsBalance = this.Balance * (1 + (((this.InterestRate / 2) * 12) / 100));
            return firstTwelveMonthsBalance * (1 + ((this.InterestRate * (months - 12)) / 100));
        }
    }
}
