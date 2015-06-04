using System;
using System.Linq;

class PCCatalog
{
    static void Main()
    {
        var catalog = new []
        {
            new Computer("Black Box", new Component("Black proc", 500), new Component("Black GUI", 800),
                new Component("Black mother", 300)),
            new Computer("Blue Box", new Component("Blue proc", 250), new Component("Blue GUI", 400),
                new Component("Blue mother", 200)), 
            new Computer("Pink Box", new Component("Pink proc", 125), new Component("Pink GUI", 200),
                new Component("Pink mother", 100))
        };

        var sortedQuery =
            from pc in catalog
            orderby pc.Price
            select pc;
        //If you can't see the entire result in the console window go to: Properties -> Layout
        //and increase the height of your screen buffer size
        foreach (Computer pc in sortedQuery)
        {
            pc.DisplayInfo();
        }
    }
}