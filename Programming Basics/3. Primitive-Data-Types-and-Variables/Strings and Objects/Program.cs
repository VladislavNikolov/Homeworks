﻿using System;

/*
 * Declare two string variables and assign them with Hello and World.
 * Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval between).
 * Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).
 */

namespace Strings_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string one = "Hello";
            string two = "World";
            object oneAndTwo = one + " " + two;
            string result = (string)oneAndTwo;

            Console.WriteLine(result);
        }
    }
}
