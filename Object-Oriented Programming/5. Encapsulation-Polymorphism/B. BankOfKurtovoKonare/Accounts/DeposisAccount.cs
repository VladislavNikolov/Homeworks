namespace B.BankOfKurtovoKonare.Accounts
{
    using System;
    using Customers;

    class DeposisAccount : Account
    {
        public DeposisAccount(Customer customer, decimal balance, decimal interestRate) 
            : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(int months)
        {
            if (this.Balance < 1000 && this.Balance >= 0)
            {
                return this.Balance;
            }

            return base.CalculateInterest(months);
        }

        public void WithdrawMoney(decimal amount)
        {
            if (amount > this.Balance)
            {
                throw new ArgumentOutOfRangeException("amount", "Cannot withdrawl more current balance.");
            }

            this.Balance -= amount;
        }
    }
}
