using System;
using System.Collections.Generic;
using System.Linq;

class ITVillage
{
    static void Main()
    {
        //Get the board markers
        List<char> firstLine = Console.ReadLine().ToCharArray().ToList();
        firstLine.RemoveAll(ch => ch == ' ' || ch == '|');

        //Fill the board
        char[,] board = new char[4,4];
        int counter = 0;
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                board[i, j] = firstLine[counter];
                counter++;
            }
        }

        //Get the starting position and dice rows
        string[] secondLine = Console.ReadLine().Split(' ');
        int row = int.Parse(secondLine[0]) - 1;
        int col = int.Parse(secondLine[1]) - 1;
        int[] diceRolls = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        //Count the number of inns
        int inns = 0;
        foreach (char ch in board)
        {
            if (ch == 'I')
            {
                inns++;
            }
        }

        //Play the game
        int diceRolled = 0;
        int coins = 50;
        int innBought = 0;
        while (true)
        {         
            //Move to the next position
            int movesMade = 0;
            coins += (innBought * 20);
            while (movesMade < diceRolls[diceRolled])
            {
                if (row == 0 && col != 3)
                {
                    col++;
                    movesMade++;
                }
                else if (col == 3 && row != 3)
                {
                    row++;
                    movesMade++;
                }
                else if (row == 3 && col != 0)
                {
                    col--;
                    movesMade++;
                }
                else if (col == 0 && row != 0)
                {
                    row--;
                    movesMade++;
                }
            }
            
            //Take action
            char newPosition = board[row, col];
            if (newPosition == 'P')
            {
                coins -= 5;
                diceRolled++;
            }
            else if (newPosition == 'I')
            {
                if (coins >= 100)
                {
                    coins -= 100;
                    innBought++;
                    diceRolled++;
                }
                else
                {
                    coins -= 10;
                    diceRolled++;
                }
            }
            else if (newPosition == 'F')
            {
                coins += 20;
                diceRolled++;
            }
            else if (newPosition == 'S')
            {
                diceRolled += 3;
            }
            else if (newPosition == 'V')
            {
                coins *= 10;
                diceRolled++;
            }
            
            //Check win-lose conditions
            if (coins < 0)
            {
                Console.WriteLine("<p>You lost! You ran out of money!<p>");
                break;
            }
            if (innBought == inns)
            {
                Console.WriteLine("<p>You won! You own the village now! You have {0} coins!<p>", coins);
                break;
            }
            if (diceRolled >= diceRolls.Length)
            {
                Console.WriteLine("<p>You lost! No more moves! You have {0} coins!<p>", coins);
                break;
            }
            if (newPosition == 'N')
            {
                Console.WriteLine("<p>You won! Nakov's force was with you!<p>");
                break;
            }
        }
    }
}