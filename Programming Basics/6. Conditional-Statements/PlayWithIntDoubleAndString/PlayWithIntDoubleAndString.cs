using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayWithIntDoubleAndString
{
    class PlayWithIntDoubleAndString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a type:");
            Console.WriteLine("1 --> int");
            Console.WriteLine("2 --> double");
            Console.WriteLine("3 --> string");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput == 1)
            {
                Console.Write("Please enter an int: ");
                int userInt = int.Parse(Console.ReadLine()) + 1;
                Console.WriteLine(userInt);
            }
            else if (userInput == 2)
            {
                Console.Write("Please enter a double: ");
                double userDouble = double.Parse(Console.ReadLine()) + 1.0;
                Console.WriteLine(userDouble);
            }
            else
            {
                Console.Write("Please enter a string: ");
                string userString = Console.ReadLine() + "*";
                Console.WriteLine(userString);
            }
        }
    }
}
