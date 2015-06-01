using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class OlympicsAreComing
{
    static void Main()
    {
        string[] data = Console.ReadLine().Split('|');
        string participant = data[0].Trim();
        participant = Regex.Replace(participant, @"\s+", " ");
        var reportWins = new Dictionary<string, int>();
        var reportParticipants = new Dictionary<string, HashSet<string>>();
        while (participant != "report")
        {
            string country = data[1].Trim();
            country = Regex.Replace(country, @"\s+", " ");
            if (!reportWins.ContainsKey(country))
            {
                reportWins.Add(country, 0);
                reportParticipants.Add(country, new HashSet<string>());
            }
            reportWins[country]++;
            reportParticipants[country].Add(participant);

            data = Console.ReadLine().Split('|');
            participant = data[0].Trim();
            participant = Regex.Replace(participant, @"\s+", " ");
        }

        foreach (var pair in reportWins.OrderByDescending(key => key.Value))
        {
            int numOfParticipants = reportParticipants[pair.Key].Count;
            Console.WriteLine("{0} ({1} participants): {2} wins", pair.Key, numOfParticipants, pair.Value);
        }
    }
}