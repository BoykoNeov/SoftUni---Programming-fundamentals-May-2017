/// <summary>
/// You are given two lines - each can be a really big number (0 to 1050). You must display the sum of these numbers.
///Note: do not use the BigInteger or BigDecimal classes for solving this problem.
/// </summary>
namespace SumBigNumbers
{
    using System;

    public class SumBigNumbers
    {
        public static void Main()
        {
            string firstNumber = Console.ReadLine();
            string secondNumber = Console.ReadLine();
            const int maxResultSize = 51;
            int[] result = new int[maxResultSize];

            // Ensures that the first number is bigger ot equal in length to the second
            if (secondNumber.Length > firstNumber.Length)
            {
                string temp = new string(secondNumber.ToCharArray());
                secondNumber = new string(firstNumber.ToCharArray());
                firstNumber = new string(temp.ToCharArray());
            }

            for (int i = 0; i < firstNumber.Length || i < secondNumber.Length; i++)
            {
                int currentDigit = 0;
                int carryDigit = 0;

                // 48 is the ascii table value of 0
                int firstNumberDigit = firstNumber[firstNumber.Length - 1 - i] - 48;

                // checks if the second number has "run" out of digits
                if (secondNumber.Length - 1 - i >= 0)
                {
                    int secondNumberDigit = secondNumber[secondNumber.Length - 1 - i] - 48;
                    currentDigit = (firstNumberDigit + secondNumberDigit) % 10;
                    carryDigit = (firstNumberDigit + secondNumberDigit) / 10;
                }
                else
                {
                    currentDigit = firstNumberDigit;
                    carryDigit = 0;
                }

                result[result.Length - 1 - i] += currentDigit;
                result[result.Length - 2 - i] += carryDigit;
            }

            // runs through the sequence and "fixes" the places where a carry is occuring
            for (int i = result.Length - 1; i > 0; i--)
            {
                if (result[i] > 9)
                {
                    result[i - 1] += result[i] / 10;
                    result[i] = result[i] % 10;
                }
            }

            string outputString = String.Join("", result).TrimStart('0');
            if (outputString.Length > 0)
            {
                Console.WriteLine(outputString);
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}