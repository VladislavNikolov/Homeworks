namespace B.BankOfKurtovoKonare.Accounts
{
    using System;
    using Customers;
    using Interfaces;

    public abstract class Account : IAccount
    {
        private Customer customer;
        private decimal balance;
        private decimal interestRate;

        protected Account(Customer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public Customer Customer { get; set; }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("balance", "Balance cannot be negative!");
                }

                this.balance = value;
            }
        }

        // Negative interest rate is possible so no validations are carried out
        public decimal InterestRate { get; set; }

        public void DepositMoney(decimal amount)
        {
            this.Balance += amount;
        }

        public virtual decimal CalculateInterest(int months)
        {
            return this.Balance * (1 + ((this.InterestRate * months) / 100));
        }
    }
}
