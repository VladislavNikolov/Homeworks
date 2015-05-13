using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckForPlayCard
{
    class CheckForPlayCard
    {
        static void Main(string[] args)
        {
            string face = Console.ReadLine();
            string[] allFaces = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            bool isValid = false;

            for (int i = 0; i < 13; i++)
            {
                if (face == allFaces[i])
                {
                    isValid = true;
                }
            }
            if (isValid)
            {
                Console.WriteLine("yes"); 
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
