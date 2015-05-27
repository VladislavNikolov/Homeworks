using System;
using System.Text.RegularExpressions;

class PINValidation
{
    static void Main()
    {
        string name = Console.ReadLine();
        string gender = Console.ReadLine();
        string PIN = Console.ReadLine();

        bool isValidName = IsValidName(name);
        bool isValidPIN = IsValidPIN(PIN, gender);
        if (isValidName && isValidPIN)
        {
            Console.WriteLine(@"{{""name"":""{0}"",""gender"":""{1}"",""pin"":""{2}""}}", name, gender, PIN);
        }
        else
        {
            Console.WriteLine("<h2>Incorrect data</h2>");
        }
    }

    static bool IsValidName(string name)
    {
        string pattern = @"[A-Z][a-z]+\s[A-Z][a-z]+";
        Match match = Regex.Match(name, pattern);
        if (match.Success)
        {
            return true;
        }
        return false;
    }

    static bool IsValidGender(string gender, int num)
    {
        if (gender == "male" && num % 2 == 0)
        {
            return true;
        }
        if (gender == "female" && num % 2 != 0)
        {
            return true;
        }
        return false;
    }

    static bool IsValidPIN(string PIN, string gender)
    {
        int month = int.Parse(PIN.Substring(2, 2));
        int day = int.Parse(PIN.Substring(4, 2));
        int determineGender = int.Parse(PIN.Substring(8, 1));
        if ((PIN.Length != 10 || month < 1 || (month > 12 && month < 21) || (month > 32 && month < 41) || 
           month > 52 || day < 1 || day > 31 || !IsValidGender(gender, determineGender)))
        {
            return false;
        }

        int checksum = int.Parse(PIN.Substring(9, 1));
        int[] checksumNums = { 2, 4, 8, 5, 10, 9, 7, 3, 6 };
        int sum = 0;
        for (int i = 0; i < 9; i++)
        {
            sum += (int.Parse(PIN[i].ToString()) * checksumNums[i]);
        }
        if (sum % 11 == 10)
        {
            if (checksum == 0)
            {
                return true;
            }
        }
        if (sum % 11 == checksum)
        {
            return true;
        }

        return false;
    }
}