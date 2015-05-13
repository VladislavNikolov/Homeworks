using System;
using System.Configuration;

class NumberCalculations
{
    static void Main()
    {
        double[] numbersDouble = {0.5, 2.0, 3.55, -6.7};
        decimal[] numbersDecimal = {2581, 2181, 1841, 1116};

        Console.WriteLine(Minimum(numbersDouble));
        Console.WriteLine(Maximum(numbersDouble));
        Console.WriteLine(Sum(numbersDouble));
        Console.WriteLine(Average(numbersDouble));
        Console.WriteLine(Product(numbersDouble));
        Console.WriteLine(Minimum(numbersDecimal));
        Console.WriteLine(Maximum(numbersDecimal));
        Console.WriteLine(Sum(numbersDecimal));
        Console.WriteLine(Average(numbersDecimal));
        Console.WriteLine(Product(numbersDecimal));
    }

    //Overloading Minimum
    static double Minimum(double[] numbers)
    {
        double minimum = Double.MaxValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < minimum)
            {
                minimum = numbers[i];
            }
        }
        return minimum;
    }

    static decimal Minimum(decimal[] numbers)
    {
        decimal minimum = decimal.MaxValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < minimum)
            {
                minimum = numbers[i];
            }
        }
        return minimum;
    }

    //Overloading Maximum
    static double Maximum(double[] numbers)
    {
        double maximum = Double.MinValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > maximum)
            {
                maximum = numbers[i];
            }
        }
        return maximum;
    }

    static decimal Maximum(decimal[] numbers)
    {
        decimal maximum = decimal.MinValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > maximum)
            {
                maximum = numbers[i];
            }
        }
        return maximum;
    }

    //Overloading Sum
    static double Sum(double[] numbers)
    {
        double sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }

    static decimal Sum(decimal[] numbers)
    {
        decimal sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }

    //Overloading Average
    static double Average(double[] numbers)
    {
        double sum = Sum(numbers);
        double average = sum / numbers.Length;

        return average;
    }

    static decimal Average(decimal[] numbers)
    {
        decimal sum = Sum(numbers);
        decimal average = sum / numbers.Length;

        return average;
    }

    //Overloading Product
    static double Product(double[] numbers)
    {
        double product = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            product *= numbers[i];
        }
        return product;
    }

    static decimal Product(decimal[] numbers)
    {
        decimal product = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            product *= numbers[i];
        }
        return product;
    }
}