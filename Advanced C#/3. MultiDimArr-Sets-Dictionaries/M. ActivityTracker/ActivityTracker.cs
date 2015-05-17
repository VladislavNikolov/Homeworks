using System;
using System.Collections.Generic;
using System.Linq;

class ActivityTracker
{
    static void Main()
    {
        //Input
        int linesNum = int.Parse(Console.ReadLine());
        string[][] data = new string[linesNum][];
        for (int i = 0; i < linesNum; i++)
        {
            data[i] = Console.ReadLine().Split(' ');
        }

        //Data Sort
        var tracker = new SortedDictionary<int, SortedDictionary<string, double>>();
        int month;
        string user;
        double distance;
        for (int i = 0; i < data.Length; i++)
        {
            month = int.Parse(data[i][0].Substring(3, 2));
            user = data[i][1];
            distance = double.Parse(data[i][2]);
            if (!tracker.ContainsKey(month))
            {
                tracker.Add(month, new SortedDictionary<string, double>());
            }
            if (!tracker[month].ContainsKey(user))
            {
                tracker[month].Add(user, distance);
            }
            else
            {
                tracker[month][user] += distance;
            }     
        }
        foreach (var pair in tracker)
        {
            int count = 1;
            Console.Write("{0}: ", pair.Key);
            foreach (var pair2 in pair.Value)
            {
                if (count == tracker[pair.Key].Count)
                {
                    Console.Write("{0}({1})", pair2.Key, pair2.Value);    
                }
                else
                {
                    Console.Write("{0}({1}), ", pair2.Key, pair2.Value);
                    count++;
                }                
            }
            Console.WriteLine();
        }
    }
}