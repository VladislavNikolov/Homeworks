﻿using System;

class LastDigitOfNumber
{
    static void Main()
    {
        int integer = int.Parse(Console.ReadLine());

        Console.WriteLine(GetLastDigitAsWord(integer));
    }

    private static string GetLastDigitAsWord(int number)
    {
        int lastNumber = number%10;
        string digitAsWord = String.Empty;
        switch (lastNumber)
        {
            case 0:
                digitAsWord = "zero";
                break;
            case 1:
                digitAsWord = "one";
                break;
            case 2:
                digitAsWord = "two";
                break;
            case 3:
                digitAsWord = "three";
                break;
            case 4:
                digitAsWord = "four";
                break;
            case 5:
                digitAsWord = "five";
                break;
            case 6:
                digitAsWord = "six";
                break;
            case 7:
                digitAsWord = "seven";
                break;
            case 8:
                digitAsWord = "eight";
                break;
            case 9:
                digitAsWord = "nine";
                break;
        }
        return digitAsWord;
    }
}