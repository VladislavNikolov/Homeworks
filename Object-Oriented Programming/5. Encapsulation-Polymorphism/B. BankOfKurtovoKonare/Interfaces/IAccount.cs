namespace B.BankOfKurtovoKonare.Interfaces
{
    using Customers;

    interface IAccount
    {
        Customer Customer { get; set; }

        decimal Balance { get; set; }

        decimal InterestRate { get; set; }

        void DepositMoney(decimal money);

        decimal CalculateInterest(int months);
    }
}
