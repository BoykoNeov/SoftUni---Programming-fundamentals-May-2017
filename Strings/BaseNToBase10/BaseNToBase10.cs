// Write a program that takes a base-N number and converts it to a base-10 number (0 to 1050), where 2 <= N <= 10.
// The input consists of 1 line containing two numbers separated by a single space.
// The first number is the base N to which you have to convert.The second one is the base N number to be converted.

namespace BaseNToBase10
{
    using System;
    using System.Linq;

    public class BaseNToBase10
    {
        public static void Main()
        {
            var inputs = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            byte baseN = byte.Parse(inputs[0]);
            string number = inputs[1];
            long output = 0;

            for (int i = number.Length-1; i >= 0; i--)
            {
                output += (long)Math.Pow(baseN, number.Length-1-i) * (number[i] - 48);
            }

            Console.WriteLine(output);
        }
    }
}