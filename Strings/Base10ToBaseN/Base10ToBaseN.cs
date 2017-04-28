// Write a program that takes a base-10 number (0 to 10^50) and converts it to a base-N number, where 2 <= N <= 10.
// The input consists of 1 line containing two numbers separated by a single space.
// The first number is the base N to which you have to convert.The second one is the base 10 number to be converted.

namespace Base10ToBaseN
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Base10ToBaseN
    {
        public static void Main()
        {
            long[] inputs = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse).ToArray();

            byte baseN = (byte)inputs[0];
            long number = inputs[1];

            byte remainder = 0;
            Stack<byte> digits = new Stack<byte>();

            while (number != 0)
            {
                remainder = (byte)(number % baseN);
                digits.Push(remainder);
                number = number / baseN;
            }

            StringBuilder output = new StringBuilder(64);

            while (digits.Count > 0)
            {
                output.Append(digits.Pop());
            }

            Console.WriteLine(output.ToString());
        }
    }
}