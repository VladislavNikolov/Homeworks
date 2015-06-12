namespace B.BankOfKurtovoKonare
{
    using System;
    using Accounts;
    using Customers;

    class BankOfKurtovoKonare
    {
        static void Main(string[] args)
        {
            DeposisAccount d = new DeposisAccount(Customer.Individual, 100, 5);
            // No interest accrued, amount is the same due to minimum 1000 balance rule
            Console.WriteLine(d.CalculateInterest(3)); 
            d.DepositMoney(2000);
            d.WithdrawMoney(1000);
            Console.WriteLine(d.CalculateInterest(5));

            LoanAccount l = new LoanAccount(Customer.Individual, 2000, 4.8M);
            // No interest accrued, amount is the same due to 3 months rule
            Console.WriteLine(l.CalculateInterest(3));
            Console.WriteLine(l.CalculateInterest(4));

            MortgageAccount m = new MortgageAccount(Customer.Company, 5000, 2);
            Console.WriteLine(m.CalculateInterest(11));
            Console.WriteLine(m.CalculateInterest(12));
            Console.WriteLine(m.CalculateInterest(13));          
        }
    }
}
