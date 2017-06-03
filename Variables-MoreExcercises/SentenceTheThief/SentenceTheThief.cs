/// <summary>
/// In the last task, you caught the thief, but in the future, everyone is multitasking and you need to calculate his sentence as well.
/// His sentence equals to the times his id overflows the numerical type sbyte. Round the years to the nearest larger integer value(5.01  6).
/// Example: If the thief’s id is 5251, that means the sentence will equal: 5251 / 127 = 41.35 years.Rounded to the next integer value, the final sentence would be 42 years.
/// Notice that the id might be negative and can overflow the negative boundary of sbyte.
/// Input
/// On the first line, you will receive the thief’s id numeral type.The type will always be one of the following: “sbyte”, “int” or “long”. 
/// On the second line, you will receive n – the count of ids you are going to receive.Each will be on a new line.
/// Output
/// If the years of the sentence are more than 1 print them in the following format:
/// Prisoner with id {id of the thief} is sentenced to { duration of the sentence }
/// years
/// Otherwise use this format:
/// Prisoner with id {id of the thief} is sentenced to { duration of the sentence }
/// year
/// Constraints
/// The type will always be one of the following: “sbyte”, “int” or “long”
/// We will use for sbyte the interval[-128…127] 
/// n will be in the interval[1…20]
/// The ids will be integers in the interval[-9223372036854775808…9223372036854775807]
/// The id will never be 0.
/// </summary>
using System;
using System.Linq;
using System.Collections.Generic;

public class SentenceTheThief
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

        long seekedNumber = (inputs.Where(x => x <= idMaxValue).OrderByDescending(x => x).FirstOrDefault());
        double divisor = 0;

        if (seekedNumber < 0)
        {
            divisor = sbyte.MinValue;
        }
        else
        {
            divisor = sbyte.MaxValue;
        }

        double result = Math.Ceiling(seekedNumber / divisor);

        Console.Write($"Prisoner with id {seekedNumber} is sentenced to {result} year");
        if (result > 1)
        {
            Console.WriteLine("s");
        }
        else
        {
            Console.WriteLine();
        }
    }
}