using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SequencesOfEqualStrings
{
    static void Main(string[] args)
    {
        string[] inputLine = Console.ReadLine().Split(' ');
        int counter = 0;

        while (counter < inputLine.Length)
        {
            Console.Write(inputLine[counter] + " ");
            counter++;
            if (counter == inputLine.Length)
            {
                Console.WriteLine();
                break;
            }
            while (inputLine[counter] == inputLine[counter - 1])
            {
                Console.Write(inputLine[counter] + " ");
                counter++;
                if (counter == inputLine.Length)
                {
                    break;
                }
            }
            Console.WriteLine();
        }
    }
}