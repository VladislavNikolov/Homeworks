using System;
using System.Collections.Generic;

//You can find the proper input at the bottom. Uncomment and then comment it again.

class Phonebook
{
    static void Main()
    {
        var phonebook = new Dictionary<string, string>();
        while (true)
        {
            //Console.WriteLine("Enter a name or type END to stop the input");
            string name = Console.ReadLine();
            if (name == "END")
            {
                break;
            }
            string number = Console.ReadLine();
            phonebook.Add(name, number);
        }

        Console.ReadLine();
        while (true)
        {
            //Console.WriteLine("Enter a name or type END to stop the query");
            string nameQuery = Console.ReadLine();
            if (nameQuery == "END")
            {
                break;
            }
            if (phonebook.ContainsKey(nameQuery))
            {
                string value = phonebook[nameQuery];
                Console.WriteLine("{0} -> {1}", nameQuery, phonebook[nameQuery]);
            }
            else
            {
                Console.WriteLine("Contact {0} does not exist.", nameQuery);
            }
        }
    }
}

//Nakov
//0888080808
//END
//search
//Mariika
//Nakov

//Nakov
//+359888001122
//RoYaL(Ivan)
//666
//Gero
//5559393
//Simo
//02/987665544
//END
//search
//Simo
//simo
//RoYaL
//RoYaL(Ivan)
//END