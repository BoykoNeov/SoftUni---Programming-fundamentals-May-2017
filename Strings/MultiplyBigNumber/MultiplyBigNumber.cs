namespace MultiplyBigNumber
{
    using System;

    /// <summary>
    ///  You are given two lines - the first one can be a really big number (0 to 10^50). 
    /// The second one will be a single digit number (0 to 9). You must display the product of these numbers.
    /// Note: do not use the BigInteger or BigDecimal classes for solving this problem.
    /// </summary>
    public class MultiplyBigNumber
    {
        public static void Main()
        {
            string inputNumber = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());
            const int inputNumberMaxDigits = 52;
            int[] resultOutput = new int[inputNumberMaxDigits];

            for (int i = 0; i < inputNumber.Length; i++)
            {
                // 48 is the ASCII value of zero
                int multiplicator = (inputNumber[inputNumber.Length - 1 - i] - 48);
                int multiplicationResult = multiplicator * multiplier;

                int positionResult = multiplicationResult % 10;
                int carry = multiplicationResult / 10;

                resultOutput[inputNumberMaxDigits - 1 - i] += positionResult;
                resultOutput[inputNumberMaxDigits - 2 - i] += carry;
            }

            for (int i = resultOutput.Length - 1; i > 0; i--)
            {
                if (resultOutput[i] > 9)
                {
                    resultOutput[i - 1] += resultOutput[i] / 10;
                    resultOutput[i] = resultOutput[i] % 10;
                }
            }

            string outputString = String.Join("", resultOutput).TrimStart('0');
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