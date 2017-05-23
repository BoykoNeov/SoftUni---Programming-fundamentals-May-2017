/// <summary>
/// Task "Debit Card Number"
/// Write a program, which receives 4 integers on the console and prints them in 4-digit debit card format. 
/// </summary>
using System;
public class DebitCardNumber
{
    public static void Main()
    {
        const byte numbers = 4;
        string[] inputs = new string[numbers];
        for (int i = 0; i < numbers; i++)
        {
            char pad = '0';
            inputs[i] = Console.ReadLine().PadLeft(4, pad);
        }

        Console.WriteLine(string.Join(" ", inputs));
    }
}