using System;
using System.Linq;

internal class StuckNumbers
{
    private static void Main()
    {
        int count = int.Parse(Console.ReadLine());
        string[] allNums = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        bool solutionFound = false;

        for (int i = 0; i < count; i++)
        {
            for (int j = 0; j < count; j++)
            {
                for (int k = 0; k < count; k++)
                {
                    for (int l = 0; l < count; l++)
                    {
                        string num1 = allNums[i];
                        string num2 = allNums[j];
                        string num3 = allNums[k];
                        string num4 = allNums[l];
                        if (num1 != num2 && num1 != num3 && num1 != num4 && num2 != num3 && num2 != num4 && num3 != num4 &&
                            (allNums[i] + allNums[j] == allNums[k] + allNums[l]))
                        {
                            solutionFound = true;
                            Console.WriteLine("{0}|{1}=={2}|{3}", num1, num2, num3, num4);
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