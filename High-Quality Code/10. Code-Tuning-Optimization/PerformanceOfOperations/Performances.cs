namespace PerformanceOfOperations
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;

    public static class Performances
    {
        private const int NumberOfTests = 1000;

        public static void IntPerformance()
        {
            int number = 1;
            int result = 1;
            DisplayExecutionTime(() =>
            {
                result = number + number;
            });

            DisplayExecutionTime(() =>
            {
                result = number - number;
            });

            DisplayExecutionTime(() =>
            {
                number++;
            });

            DisplayExecutionTime(() =>
            {
                ++number;
            });

            DisplayExecutionTime(() =>
            {
                result += number;
            });

            DisplayExecutionTime(() =>
            {
                result = number * number;
            });

            DisplayExecutionTime(() =>
            {
                result += number / number;
            });

        }

        public static void LongPerformance()
        {
            long number = 30000000000;
            long result = 30000000000;
            DisplayExecutionTime(() =>
            {
                result = number + number;
            });

            DisplayExecutionTime(() =>
            {
                result = number - number;
            });

            DisplayExecutionTime(() =>
            {
                number++;
            });

            DisplayExecutionTime(() =>
            {
                ++number;
            });

            DisplayExecutionTime(() =>
            {
                result += number;
            });

            DisplayExecutionTime(() =>
            {
                result = number * number;
            });

            DisplayExecutionTime(() =>
            {
                result += number / number;
            });

        }

        public static void DoublePerformance()
        {
            double number = 1.0;
            double result = 1.0;
            DisplayExecutionTime(() =>
            {
                result = number + number;
            });

            DisplayExecutionTime(() =>
            {
                result = number - number;
            });

            DisplayExecutionTime(() =>
            {
                number++;
            });

            DisplayExecutionTime(() =>
            {
                ++number;
            });

            DisplayExecutionTime(() =>
            {
                result += number;
            });

            DisplayExecutionTime(() =>
            {
                result = number * number;
            });

            DisplayExecutionTime(() =>
            {
                result += number / number;
            });

        }

        public static void DecimalPerformance()
        {
            decimal number = 1.0M;
            decimal result = 1.0M;
            DisplayExecutionTime(() =>
            {
                result = number + number;
            });

            DisplayExecutionTime(() =>
            {
                result = number - number;
            });

            DisplayExecutionTime(() =>
            {
                number++;
            });

            DisplayExecutionTime(() =>
            {
                ++number;
            });

            DisplayExecutionTime(() =>
            {
                result += number;
            });

            DisplayExecutionTime(() =>
            {
                result = number * number;
            });

            DisplayExecutionTime(() =>
            {
                result += number / number;
            });

        }

        public static void SqareRootPerformance()
        {
            double numberDouble = 50;
            double result = 0;
            DisplayExecutionTime(() =>
            {
                result = Math.Sqrt(numberDouble);
            });
        }

        public static void NaturalLogarithmPerformance()
        {
            double numberDouble = 50;
            double result = 0;
            DisplayExecutionTime(() =>
            {
                result = Math.Log(numberDouble);
            });
        }

        public static void SinePerformance()
        {
            double numberDouble = 50;
            double result = 0;
            DisplayExecutionTime(() =>
            {
                result = Math.Sin(numberDouble);
            });
        }

        private static void DisplayExecutionTime(Action action)
        {
            Stopwatch stopwatch = new Stopwatch();
            List<double> tests = new List<double>();
            for (int i = 0; i < NumberOfTests; i++)
            {
                stopwatch.Start();
                action();
                stopwatch.Stop();

                if (i != 0)
                {
                    tests.Add(stopwatch.Elapsed.TotalMilliseconds);
                }

                stopwatch.Reset();             
            }

            double averageMiliseconds = tests.Average();

            Console.WriteLine("{0:F6}", averageMiliseconds);
        }
    }
}
