using System;

class CollectTheCoins
{
    static void Main()
    {
        //Fill the board
        char[][] gameBoard = new char[4][];
        for (int i = 0; i < 4; i++)
        {
            gameBoard[i] = Console.ReadLine().ToCharArray();
        }

        //Execute the commands
        char[] command = Console.ReadLine().ToCharArray();
        int coinsCollected = 0;
        int wallsHit = 0;
        int row = 0;
        int col = 0;
        for (int i = 0; i < command.Length; i++)
        {
            if (command[i] == '>')
            {
                bool isWallHit = IsWallHit(gameBoard, row, col + 1);
                if (isWallHit)
                {
                    wallsHit++;
                }
                else
                {
                    if (gameBoard[row][col + 1] == '$')
                    {
                        coinsCollected++;
                    }
                    col++;
                }
            }
            else if (command[i] == '<')
            {
                bool isWallHit = IsWallHit(gameBoard, row, col - 1);
                if (isWallHit)
                {
                    wallsHit++;
                }
                else
                {
                    if (gameBoard[row][col - 1] == '$')
                    {
                        coinsCollected++;
                    }
                    col--;
                }
            }
            else if (command[i] == 'V' || command[i] == 'v')
            {
                bool isWallHit = IsWallHit(gameBoard, row + 1, col);
                if (isWallHit)
                {
                    wallsHit++;
                }
                else
                {
                    if (gameBoard[row + 1][col] == '$')
                    {
                        coinsCollected++;
                    }
                    row++;
                }
            }
            else if (command[i] == '^')
            {
                bool isWallHit = IsWallHit(gameBoard, row - 1, col);
                if (isWallHit)
                {
                    wallsHit++;
                }
                else
                {
                    if (gameBoard[row - 1][col] == '$')
                    {
                        coinsCollected++;
                    }
                    row--;
                }
            }
        }
        Console.WriteLine("Coins collected: {0}", coinsCollected);
        Console.WriteLine();
        Console.WriteLine("Walls hit: {0}", wallsHit);
    }

    static bool IsWallHit(char[][] gameBoard, int row, int col)
    {
        bool isWallHit = row < 0 || row > 4 || col < 0 || col >= gameBoard[row].Length;

        return isWallHit;
    }
}