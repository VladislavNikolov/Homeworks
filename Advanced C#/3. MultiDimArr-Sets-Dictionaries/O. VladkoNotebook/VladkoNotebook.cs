using System;
using System.Collections;
using System.Collections.Generic;

class VladkoNotebook
{
    static void Main()
    {
        var notebook = new SortedDictionary<string, SortedDictionary<string, dynamic>>();
        string[] data = new string[3];
        string page = Console.ReadLine();

        //Fill the notebook
        while (page != "END")
        {
            data = page.Split('|');
            string color = data[0];
            string category = data[1];
            string statistic = data[2];
            if (!notebook.ContainsKey(color))
            {
                notebook[color] = new SortedDictionary<string, dynamic>();
            }
            if (category == "name")
            {
                if (!notebook[color].ContainsKey(category))
                {
                    notebook[color][category] = statistic;
                }
            }
            else if (category == "age")
            {
                if (!notebook[color].ContainsKey(category))
                {
                    notebook[color][category] = statistic;
                }
            }
            else
            {
                if (!notebook[color].ContainsKey("opponents"))
                {
                    notebook[color]["opponents"] = new List<string>();
                    notebook[color]["rank"] = 1.0M;
                    notebook[color]["wins"] = 1.0M;
                    notebook[color]["losses"] = 1.0M;

                }
                notebook[color]["opponents"].Add(statistic);
                if (category == "win")
                {
                    notebook[color]["wins"] += 1.0M;
                }
                else
                {
                    notebook[color]["losses"] += 1.0M;
                }
            }
            page = Console.ReadLine();
        }

        //Remove incomplete entries
        var keysToRemove = new List<string>();
        foreach (var pair in notebook)
        {
            if (!notebook[pair.Key].ContainsKey("age") || !notebook[pair.Key].ContainsKey("name"))
            {
                keysToRemove.Add(pair.Key);
            }
        }
        foreach (var key in keysToRemove)
        {
            notebook.Remove(key);
        }

        //Check for empty opponents
        foreach (var pair in notebook)
        {
            if (!notebook[pair.Key].ContainsKey("opponents"))
            {
                notebook[pair.Key]["opponents"] = new List<string>();
                notebook[pair.Key]["opponents"].Add("(empty)");
                notebook[pair.Key]["rank"] = 1.0M;
                notebook[pair.Key]["wins"] = 1.0M;
                notebook[pair.Key]["losses"] = 1.0M;
            }
        }

        //Sort Opponents and get ranks
        foreach (var pair in notebook)
        {
            notebook[pair.Key]["opponents"].Sort();
            decimal rank = notebook[pair.Key]["wins"] / notebook[pair.Key]["losses"];
            notebook[pair.Key]["rank"] = rank.ToString("F2");
            notebook[pair.Key].Remove("wins");
            notebook[pair.Key].Remove("losses");
        }

        //Print result
        if (notebook.Count == 0)
        {
            Console.WriteLine("No data recovered.");
        }
        else
        {
            foreach (var pair in notebook)
            {
                Console.WriteLine("Color: {0}", pair.Key);
                foreach (var subpair in pair.Value)
                {
                    Console.WriteLine("-{0}: {1}", subpair.Key, string.Join(", ", subpair.Value));
                }
            }
        }     
    }
}