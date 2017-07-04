using System;
using System.Linq;
using System.Text.RegularExpressions;

/// <summary>
/// Last night Pesho received the email of a girl. Unfortunately, he cannot
/// remember whether she was worth it. He has a plan on how to decide if he should 
/// message the girl and he needs your programming skills.
/// He will give you her email and your task is to subtract the sum of the 
/// characters after the ‘@’ from the sum of the characters before the ‘@’.
/// If the result is equal or greater than 0 – he will write her email, otherwise he will not.
/// </summary>
public class EmailMe
{
    public static void Main()
    {
        const string pattern = @"(\S+)@(\S+)";
        string inputEmail = Console.ReadLine();

        Regex regex = new Regex(pattern);
        Match match = regex.Match(inputEmail);

        if ((match.Groups[1].Value.Select(Convert.ToInt32).Sum() - match.Groups[2].Value.Select(Convert.ToInt32).Sum()) >= 0)
        {
            Console.WriteLine("Call her!");
        }
        else
        {
            Console.WriteLine("She is not the one.");
        }
    }
}