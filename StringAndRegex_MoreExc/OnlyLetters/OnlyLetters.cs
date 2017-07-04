using System;
using System.Text;

public class OnlyLetters
{
    public static void Main()
    {
        string input = Console.ReadLine();
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < input.Length; i++)
        {
            if (char.IsDigit(input[i]))
            {
                try
                {
                    if (!char.IsDigit(input[i + 1]))
                    {
                        sb.Append(input[i + 1]);
                    }
                }
                catch
                {
                    int counter = 0;
                    // end of string is reached
                    while (char.IsDigit(input[i]))
                    {
                        sb.Insert(sb.Length - counter++, input[i]);
                        i--;
                    }

                    break;
                }
            }
            else
            {
                sb.Append(input[i]);
            }
        }

        Console.WriteLine(sb.ToString());
    }
}