using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security;
using System.Text.RegularExpressions;

class ChatLogger
{
    static void Main()
    {
        DateTime currentTime = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy HH:mm:ss", CultureInfo.InvariantCulture);      

        //Sort the messages
        var chat = new SortedDictionary<DateTime, string>();
        string chatLine = Console.ReadLine();
        string pattern = @"(.+)\s\/\s(.+)";
        while (chatLine != "END")
        {
            MatchCollection matches = Regex.Matches(chatLine, pattern);
            foreach (Match match in matches)
            {
                string message = match.Groups[1].ToString();
                DateTime date = DateTime.ParseExact(match.Groups[2].ToString(), "dd-MM-yyyy HH:mm:ss",
                    CultureInfo.InvariantCulture);
                chat.Add(date, message);
            }
            chatLine = Console.ReadLine();
        }

        //Print the ordered messages
        foreach (var pair in chat)
        {
            string result = SecurityElement.Escape(pair.Value);
            Console.WriteLine("<div>{0}</div>", result);
        }

        //Print the last line
        DateTime lastTime = chat.Keys.Last();
        var span = (currentTime - lastTime).TotalSeconds;
        if (currentTime.Day == lastTime.Day + 1)
        {
            Console.WriteLine("<p>Last active: <time>yesterday</time></p>");
        }
        else if (span < 60.0)
        {
            Console.WriteLine("<p>Last active: <time>a few moments ago</time></p>");
        }
        else if (span < 3600.0)
        {
            int minutes = (int)(span / 60);
            Console.WriteLine("<p>Last active: <time>{0} minute(s) ago</time></p>", minutes);
        }
        else if (currentTime.Day == lastTime.Day)
        {
            int hours = (int)(span / 3600);
            Console.WriteLine("<p>Last active: <time>{0} hour(s) ago</time></p>", hours);
        }
        else
        {
            string format = "dd-MM-yyyy";
            Console.WriteLine("<p>Last active: <time>{0}</time></p>", lastTime.ToString(format));
        }
    }
}