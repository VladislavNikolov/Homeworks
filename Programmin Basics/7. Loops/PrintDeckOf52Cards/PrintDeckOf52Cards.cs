using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintDeckOf52Cards
{
    class PrintDeckOf52Cards
    {
        static void Main(string[] args)
        {
            string[] faces = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

            for (int face = 0; face < 13; face++)
            {
                for (int suit = 0; suit < 4; suit++)
                {
                    switch(suit)
                    {
                        case 0:
                            Console.Write(faces[face] + "♣" + " ");          
                            break;
                        case 1:
                            Console.Write(faces[face] + "♦" + " ");
                            break;
                        case 2:
                            Console.Write(faces[face] + "♥" + " ");
                            break;
                        case 3:
                            Console.Write(faces[face] + "♠");
                            break;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
