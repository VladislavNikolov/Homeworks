using System;

internal class PythagoreanNumbers
{
    private static void Main()
    {
        int count = int.Parse(Console.ReadLine());
        int[] allNums = new int[count];
        for (int i = 0; i < count; i++)
        {
            allNums[i] = int.Parse(Console.ReadLine());
        }

        bool solutionFound = false;
        for (int i = 0; i < count; i++)
        {
            int a = allNums[i];
            for (int j = 0; j < count; j++)
            {
                int b = allNums[j];
                if (a <= b)
                {
                    for (int k = 0; k < count; k++)
                    {
                        int c = allNums[k];
                        if (a * a + b * b == c * c)
                        {
                            Console.WriteLine("{0}*{0} + {1}*{1} = {2}*{2}", a, b, c);
                            solutionFound = true;
                        }
                    }
                }
            }
        }

        if (!solutionFound)
        {
            Console.WriteLine("No");
        }
    }
}