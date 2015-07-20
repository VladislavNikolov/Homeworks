namespace PerformanceOfOperations
{
    using System;

    class PerformanceOfOperations
    {
        static void Main(string[] args)
        {
            // Refer to Results.txt for the tables.
            // Due to the incredibly small numbers, results may vary!
            // Math.Sqrt(), Math.Log() and Math.Sin() accept only doulbe as parameters
            // therefore float and decimal cannot be tested.

            Console.WriteLine("Int:");
            Performances.IntPerformance();

            Console.WriteLine("{0}Long:", Environment.NewLine);
            Performances.LongPerformance();

            Console.WriteLine("{0}Double:", Environment.NewLine);
            Performances.DoublePerformance();

            Console.WriteLine("{0}Decimal:", Environment.NewLine);
            Performances.DecimalPerformance();

            Console.WriteLine("{0}Sqare root:", Environment.NewLine);
            Performances.SqareRootPerformance();

            Console.WriteLine("{0}Natural logarithm:", Environment.NewLine);
            Performances.NaturalLogarithmPerformance();

            Console.WriteLine("{0}Sine:", Environment.NewLine);
            Performances.SinePerformance();
        }  
    }
}
