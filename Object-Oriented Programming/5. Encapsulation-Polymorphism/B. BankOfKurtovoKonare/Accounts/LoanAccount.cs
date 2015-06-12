namespace B.BankOfKurtovoKonare.Accounts
{
    using Customers;

    class LoanAccount : Account
    {
        public LoanAccount(Customer customer, decimal balance, decimal interestRate) 
            : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(int months)
        {
            if (this.Customer == Customer.Individual)
            {
                if (months > 3)
                {
                    return base.CalculateInterest(months - 3);
                }

                return this.Balance;
            }

            // if (this.Customer == Customer.Company)
            if (months > 2)
            {
                return base.CalculateInterest(months - 2);
            }

            return this.Balance;
        }
    }
}
