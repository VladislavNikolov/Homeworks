using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;

class NightLife
{
    static void Main()
    {
        var info = new Dictionary<string, SortedDictionary<string, SortedSet<string>>>();

        while (true)
        {
            string[] data = Console.ReadLine().Split(';');
            if (data[0] == "END")
            {
                break;
            }
            string city = data[0];
            string venue = data[1];
            string performer = data[2];

            if (!info.ContainsKey(city))
            {
                info[city] = new SortedDictionary<string, SortedSet<string>>();
            }
            if (!info[city].ContainsKey(venue))
            {
                info[city][venue] = new SortedSet<string>();
            }
            if (!info[city][venue].Contains(performer))
            {
                info[city][venue].Add(performer);
            }

        }
        foreach (var pair in info)
        {
            Console.WriteLine(pair.Key);
            foreach (var pair2 in pair.Value)
            {
                Console.WriteLine("->{0}: {1}", pair2.Key, String.Join(", ", pair2.Value));
            }
        }
    }
}
