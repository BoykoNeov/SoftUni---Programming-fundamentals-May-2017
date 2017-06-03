/// <summary>
/// In the future, a very dangerous thief has escaped. Your mission is to catch him, but the only thing you know is the numeral type, which is his id.
/// On the first line, you will receive the numeral type of thief’s id.On the second line, you will receive n – the number of ids you will receive.The person who has an id closest to the maximum value of the given numeral type without overflowing it is the thief’s id.
/// Input
/// On the first line, you will receive the thief’s id numeral type. The type will always be one of the following: “sbyte”, “int” or “long”. 
/// On the second line, you will receive n – the count of ids you are going to receive.Each will be on a new line.
/// Output
/// Print the id of the thief.
/// Constraints
/// The type will always be one of the following: “sbyte”, “int” or “long”
/// The sbyte interval will be[-128…127]
/// The number n will be in the interval[1…20].
/// The ids will be integers in the interval[-9223372036854775808…9223372036854775807]
/// </summary>
using System;
using System.Linq;
using System.Collections.Generic;

public class CatchTheThief
{
    public static void Main()
    {
        string idType = Console.ReadLine();
        int n = byte.Parse(Console.ReadLine());
        List<long> inputs = new List<long>();
        for (int i = 0; i < n; i++)
        {
            inputs.Add(long.Parse(Console.ReadLine()));
        }

        long idMaxValue = 0;
        if (idType == "sbyte")
        {
            idMaxValue = sbyte.MaxValue;
        }
        else if (idType == "int")
        {
            idMaxValue = int.MaxValue;
        }
        else
        {
            idMaxValue = long.MaxValue;
        }

        Console.WriteLine(inputs.Where(x => x <= idMaxValue).OrderByDescending(x => x).FirstOrDefault());
    }
}