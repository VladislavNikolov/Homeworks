using System;

class CommandInterpreter
{
    static void Main()
    {
        string[] allStrings = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string[] command = Console.ReadLine().Split(' ');
        while (command[0] != "end")
        {
            if (command[0] == "reverse")
            {
                int start = int.Parse(command[2]);
                int count = int.Parse(command[4]);
                if (start >= 0 && start < allStrings.Length && (start + count <= allStrings.Length) && count > -1)
                {
                    string[] reversed = new string[count];
                    int counter = start;
                    for (int i = 0; i < count; i++)
                    {
                        reversed[i] = allStrings[counter];
                        counter++;
                    }
                    Array.Reverse(reversed);
                    for (int i = 0; i < count; i++)
                    {
                        allStrings[start] = reversed[i];
                        start++;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input parameters.");
                }
            }
            else if (command[0] == "sort")
            {
                int start = int.Parse(command[2]);
                int count = int.Parse(command[4]);
                if (start >= 0 && start < allStrings.Length && (start + count <= allStrings.Length) && count > -1)
                {
                    string[] sorted = new string[count];
                    int counter = start;
                    for (int i = 0; i < count; i++)
                    {
                        sorted[i] = allStrings[counter];
                        counter++;
                    }
                    Array.Sort(sorted);
                    for (int i = 0; i < count; i++)
                    {
                        allStrings[start] = sorted[i];
                        start++;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input parameters.");
                }
            }
            else if (command[0] == "rollLeft")
            {
                int count = int.Parse(command[1]);
                if (count > -1)
                {
                    count %= allStrings.Length;
                    for (int i = 0; i < count; i++)
                    {
                        string[] toLeft = new string[allStrings.Length];
                        for (int j = 0; j < allStrings.Length; j++)
                        {
                            toLeft[j] = allStrings[j];
                        }
                        for (int j = 0; j < allStrings.Length; j++)
                        {
                            if (j != allStrings.Length - 1)
                            {
                                allStrings[j] = toLeft[j + 1];
                            }
                            else
                            {
                                allStrings[j] = toLeft[0];
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input parameters.");
                }
            }
            else if (command[0] == "rollRight")
            {
                int count = int.Parse(command[1]);
                if (count > -1)
                {
                    count %= allStrings.Length;
                    for (int i = 0; i < count; i++)
                    {
                        string[] toRight = new string[allStrings.Length];
                        for (int j = 0; j < allStrings.Length; j++)
                        {
                            toRight[j] = allStrings[j];
                        }
                        for (int j = 0; j < allStrings.Length; j++)
                        {
                            if (j != 0)
                            {
                                allStrings[j] = toRight[j - 1];
                            }
                            else
                            {
                                allStrings[j] = toRight[allStrings.Length - 1];
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input parameters.");
                }
            }
            command = Console.ReadLine().Split(' ');
        }
        Console.WriteLine("[{0}]", string.Join(", ", allStrings));
    }
}