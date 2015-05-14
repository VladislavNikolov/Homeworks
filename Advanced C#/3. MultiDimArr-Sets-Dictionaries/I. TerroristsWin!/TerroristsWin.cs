using System;

internal class TerroristsWin
{
    private static void Main()
    {
        string bombSite = Console.ReadLine();
        char[] bombed = bombSite.ToCharArray();
        bool openingBracket = true;

        for (int i = 0; i < bombSite.Length; i++)
        {
            if (bombSite[i] == '|')
            {
                //Check to see if we have bombed already
                if (openingBracket)
                {
                    openingBracket = false;
                    int openIndex = i;
                    int closeIndex = i + 1;
                    int radius = 0;
                    while (true)
                    {
                        //Exploding the insides of the bomb
                        if (bombSite[closeIndex] != '|')
                        {
                            radius += bombSite[closeIndex];
                            bombed[closeIndex] = '.';
                            closeIndex++;
                        }
                        //Exploding the walls of the bomb and around it
                        else
                        {
                            radius = radius%10;
                            for (int j = 0; j <= radius; j++)
                            {
                                if (openIndex - j > -1)
                                {
                                    bombed[openIndex - j] = '.';
                                }
                                if (closeIndex + j < bombed.Length)
                                {
                                    bombed[closeIndex + j] = '.';
                                }              
                            }
                            break;
                        }
                    }
                }
                else
                {
                    openingBracket = true;
                }
            }
        }
        Console.WriteLine(new string(bombed));
    }
}