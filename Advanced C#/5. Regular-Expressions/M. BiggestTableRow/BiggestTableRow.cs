using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

internal class BiggestTableRow
{
    private static void Main()
    {
        string tableRow = Console.ReadLine();
        tableRow = Console.ReadLine();
        tableRow = Console.ReadLine();
        decimal highestSum = Decimal.MinValue;
        string bestRow = String.Empty;
        while (tableRow != "</table>")
        {
            MatchCollection matches = Regex.Matches(tableRow, @"\-?\d+\.?\d*");
            decimal currentSum = 0;

            foreach (Match match in matches)
            {
                currentSum += decimal.Parse(match.ToString());
            }
            if (currentSum > highestSum)
            {
                highestSum = currentSum;
                List<string> tempList = new List<string>();
                foreach (Match match in matches)
                {
                    tempList.Add(match.ToString());
                }
                string allNums = string.Join(" + ", tempList);
                bestRow = highestSum.ToString("G29") + " = " + allNums;
            }
            tableRow = Console.ReadLine();
        }
        if (bestRow == "0 = ")
        {
            Console.WriteLine("no data");
        }
        else
        {
            Console.WriteLine(bestRow);
        }
    }
}