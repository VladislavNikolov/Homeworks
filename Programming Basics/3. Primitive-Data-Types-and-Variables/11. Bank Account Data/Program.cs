using System;

/*
 * A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
 * Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.
 */

namespace Bank_Account_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Vladislav";
            string middleName = "Vencislavov";
            string lastName = "Nikolov";
            decimal balance = 7642.45M;
            string bankName = "ING";
            string IBAN = "BG25INGB2514584354315";
            long cardNum1 = 1234567812345678;
            long cardNum2 = 1234567812345679;
            long cardNum3 = 1234567812345677;

            Console.WriteLine("Account holder's name: {0} {1} {2}", firstName, middleName, lastName);
            Console.WriteLine("Available balance: {0}", balance);
            Console.WriteLine("Bank's name: {0}", bankName);
            Console.WriteLine("IBAN: {0}", IBAN);
            Console.WriteLine("Your first card's number: {0}", cardNum1);
            Console.WriteLine("Your first card's number: {0}", cardNum2);
            Console.WriteLine("Your first card's number: {0}", cardNum3);
        }
    }
}
