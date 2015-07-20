using System;
using System.Collections.Generic;
using System.Text;

class Exceptions
{
    public static T[] Subsequence<T>(T[] arr, int startIndex, int count)
    {
        if (startIndex < 0)
        {
            throw new ArgumentOutOfRangeException("Start index must be positive.");
        }
        if (startIndex >= arr.Length)
        {
            throw new ArgumentOutOfRangeException("Start index must be less than the length of the array.");
        }
        if (count > arr.Length - startIndex)
        {
            throw new ArgumentOutOfRangeException(
                "Count must be less than the length of the array minus the start index.");
        }

        List<T> result = new List<T>();
        for (int i = startIndex; i < startIndex + count; i++)
        {
            result.Add(arr[i]);
        }
        return result.ToArray();
    }

    public static string ExtractEnding(string str, int count)
    {
        if (count > str.Length)
        {
            throw new ArgumentOutOfRangeException(
                "Count must be less than or equal to the length of the array.");
        }

        StringBuilder result = new StringBuilder();
        for (int i = str.Length - count; i < str.Length; i++)
        {
            result.Append(str[i]);
        }
        return result.ToString();
    }

    public static void CheckPrime(int number)
    {
        for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
        {
            if (number % divisor == 0)
            {
                Console.WriteLine("{0} is not prime.", number);
                return;
            }
        }

        Console.WriteLine("{0} is prime.", number);
    }

    private static void Main()
    {
        try
        {
            var substr = Subsequence("Hello!".ToCharArray(), 2, 3);
            Console.WriteLine(substr);

            var subarr = Subsequence(new int[] {-1, 3, 2, 1}, 0, 2);
            Console.WriteLine(String.Join(" ", subarr));

            var allarr = Subsequence(new int[] {-1, 3, 2, 1}, 0, 4);
            Console.WriteLine(String.Join(" ", allarr));

            var emptyarr = Subsequence(new int[] {-1, 3, 2, 1}, 0, 0);
            Console.WriteLine(String.Join(" ", emptyarr));

            Console.WriteLine(ExtractEnding("I love C#", 2));
            Console.WriteLine(ExtractEnding("Nakov", 4));
            Console.WriteLine(ExtractEnding("beer", 4));
            //Console.WriteLine(ExtractEnding("Hi", 100));

            CheckPrime(23);
            CheckPrime(33);

            List<Exam> peterExams = new List<Exam>()
            {
                new SimpleMathExam(2),
                new CSharpExam(55),
                new CSharpExam(100),
                new SimpleMathExam(1),
                new CSharpExam(0),
            };
            Student peter = new Student("Peter", "Petrov", peterExams);
            double peterAverageResult = peter.CalcAverageExamResultInPercents();
            Console.WriteLine("Average results = {0:p0}", peterAverageResult);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex);
        }
        catch (NullReferenceException ex)
        {
            Console.WriteLine(ex);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex);
        }
    }
}
