/// <summary>
/// A master number is an integer that holds the following properties:
/// Is symmetric(palindrome), e.g. 5, 77, 282, 14341, 9553559.
/// Its sum of digits is divisible by 7, e.g. 77, 313, 464, 5225, 37173.
/// Holds at least one even digit, e.g. 232, 707, 6886, 87578.
/// Write a program to print all master numbers in the range[1…n].
/// </summary>
using System;
using System.Linq;
public class MasterNumbers
{
    public static void Main()
    {
        int inputNumberLimit = int.Parse(Console.ReadLine());
        for (int i = 1; i <= inputNumberLimit; i++)
        {
            string number = i.ToString();
            bool notMagicNumber = false;

            for (int j = 0; j < number.Length / 2; j++)
            {
                if (number[j] != number[number.Length - 1 - j])
                {
                    notMagicNumber = true;
                    break;
                }
            }

            if (notMagicNumber)
            {
                continue;
            }

            notMagicNumber = true;

            // 48 is '0' in ascii table , 49 is '1' and so on
            for (int k = 0; k < number.Length; k++)
            {
                if ((number[k] - 48) % 2 == 0)
                {
                    notMagicNumber = false;
                }
            }

            if (notMagicNumber)
            {
                continue;
            }

            if (number.Select(x => x - 48)
                .Sum() % 7 != 0)
            {
                continue;
            }

            Console.WriteLine(number);
        }
    }
}