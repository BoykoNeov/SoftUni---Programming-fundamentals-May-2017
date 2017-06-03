/// <summary>
/// Write a program, which reads three lines from the console. On the first line,
/// there will be delimiter (char) – you have to separate the strings by this delimiter. 
/// The second line will be either “even” or “odd”. If you receive “odd”, you have to take
/// every odd string and vice versa if you receive “even”. The last line will be the number 
/// of lines – n which you will receive. The first iteration of the loop starts from 1.
/// Print the newly created string on a new line.
/// </summary>
using System;
using System.Collections.Generic;

public class StringConcatenation
{
    public static void Main()
    {
        string delimiter = (Console.ReadLine());
        string evenORodd = Console.ReadLine();
        int n = int.Parse(Console.ReadLine());

        List<string> Even = new List<string>();
        List<string> Odd = new List<string>();

        for (int i = 1; i <= n; i++)
        {
            if (i % 2 == 0)
            {
                Even.Add(Console.ReadLine());
            }
            else
            {
                Odd.Add(Console.ReadLine());
            }
        }

        if (evenORodd == "odd")
        {
            Console.WriteLine(string.Join(delimiter, Odd));
        }
        else
        {
            Console.WriteLine(string.Join(delimiter, Even));
        }
    }
}