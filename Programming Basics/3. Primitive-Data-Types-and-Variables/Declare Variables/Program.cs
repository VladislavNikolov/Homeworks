﻿using System;

/* 
 *Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
 *Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.
 */

namespace Declare_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort num1 = 52130;
            sbyte num2 = -115;
            int num3 = 4825932;
            byte num4 = 97;
            short num5 = -10000;

            Console.WriteLine("{0}, {1}, {2}, {3}, {4}", num1, num2, num3, num4, num5);
        }
    }
}
