using System;

class PrintCompanyInformation
{
    static void Main()
    {
        Console.Write("Company name: ");
        string compName = Console.ReadLine();
        Console.Write("Company address: ");
        string compAddress = Console.ReadLine();
        Console.Write("Phone number: ");
        string compPhone = Console.ReadLine();
        Console.Write("Fax number: ");
        string compFax = Console.ReadLine();
        Console.Write("Web site: ");
        string compSite = Console.ReadLine();
        Console.Write("Manager first name: ");
        string managerFirstName = Console.ReadLine();
        Console.Write("Manager last name: ");
        string managerLastName = Console.ReadLine();
        Console.Write("Manager age: ");
        string managerAge = Console.ReadLine();
        Console.Write("Manager phone: ");
        string managePhone = Console.ReadLine();
        Console.WriteLine(compName);
        Console.WriteLine(compAddress);
        Console.WriteLine(compPhone);
        Console.WriteLine(compFax);
        Console.WriteLine(compSite);
        Console.WriteLine("{0} {1} (age: {2}, tel. {3}", managerFirstName, managerLastName, managerAge, managePhone);
    }
}