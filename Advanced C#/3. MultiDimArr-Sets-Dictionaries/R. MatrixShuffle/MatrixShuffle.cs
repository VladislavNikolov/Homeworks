using System;
using System.Linq;
using System.Text;

class MatrixShuffle
{
    private static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        string text = Console.ReadLine();
        char[,] matrix = new char[size, size];

        //Fill the matrix
        int row = 0;
        int col = 0;
        int letterIndex = 0;

        while (letterIndex < size*size)
        {
            while (col < size && matrix[row, col] == 0)
            {
                matrix[row, col] = text[letterIndex];
                col++;
                letterIndex++;
            }

            col--;
            row++;

            while (row < size && matrix[row, col] == 0)
            {
                matrix[row, col] = text[letterIndex];
                row++;
                letterIndex++;
            }

            row--;
            col--;

            while (col >= 0 && matrix[row, col] == 0)
            {
                matrix[row, col] = text[letterIndex];
                col--;
                letterIndex++;
            }

            col++;
            row--;

            while (row >= 0 && matrix[row, col] == 0)
            {
                matrix[row, col] = text[letterIndex];
                row--;
                letterIndex++;
            }

            row++;
            col++;
        }

        //Extract the letters
        string result = Result(matrix, size);  

        //Check if result is plaindrome
        bool palindrome = IsPalindrome(result);

        //Print result
        if (palindrome)
        {
            Console.WriteLine("<div style='background-color:#4FE000'>{0}</div>", result);
        }
        else
        {
            Console.WriteLine("<div style='background-color:#E0000F'>{0}</div>", result);
        }
    }

    static string Result(char[,] matrix, int size)
    {
        StringBuilder whitePattern = new StringBuilder();
        StringBuilder blackPattern = new StringBuilder();
        bool isWhite = true;
        if (size % 2 == 0)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (isWhite)
                    {
                        whitePattern.Append(matrix[row, col]);
                        isWhite = false;
                    }
                    else
                    {
                        blackPattern.Append(matrix[row, col]);
                        isWhite = true;
                    }
                }
                if (isWhite)
                {
                    isWhite = false;
                }
                else
                {
                    isWhite = true;
                }
            }
        }
        else
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (isWhite)
                    {
                        whitePattern.Append(matrix[row, col]);
                        isWhite = false;
                    }
                    else
                    {
                        blackPattern.Append(matrix[row, col]);
                        isWhite = true;
                    }
                }
            }
        }
        string result = whitePattern.ToString() + blackPattern.ToString();
        return result;
    }

    static bool IsPalindrome(string str)
    {
        StringBuilder sb = new StringBuilder();
        foreach (char ch in str)
        {
            if (char.IsLetter(ch) && ch != ' ')
            {
                sb.Append(char.ToLower(ch));
            }
        }
        char[] arr = sb.ToString().ToCharArray();
        Array.Reverse(arr);
        string reversed = new string(arr);
        if (sb.ToString() == reversed)
        {
            return true;
        }
        return false;
    }
}