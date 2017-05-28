/// <summary>
/// Write a program, which finds all the possible combinations between two numbers – N and M.
/// The first digit decreases from N to 1, and the second digit increases from 1 to M.
/// The two digits form a number.Multiply the two digits, then multiply their product by 3. Add the result to the total sum.
/// You will also be given a third number, which will be the maximum boundary of the sum.
/// If the sum is equal or greater than this number you should stop the program. See the examples for further information. 
/// Input
/// The input is read from the console and consists of three lines: 
/// First line – N – integer in the interval [1…100]
/// Second line – M – integer in the interval [1…100]
/// Third line – maximum sum boundary – integer in the interval [1…1000000]
/// Output
/// The output depends on the result:
/// If the sum is equal or greater than the maximum sum:
/// "{count of combinations} combinations"
///  "Sum: {sum from the combinations} >= {maximum sum}"
/// If the sum is less than the maximum sum:
/// "{count of combinations} combinations"
/// "Sum: {sum from the combinations}"
/// </summary>
using System;
public class TestNumbers
{
   public static void Main()
    {
        byte firstNumber = byte.Parse(Console.ReadLine());
        byte secondNumber = byte.Parse(Console.ReadLine());
        int sumBoundary = int.Parse(Console.ReadLine());

        int sum = 0;
        int totalCombinations = 0;
        bool isBoundaryPassed = false;

        for (int i = firstNumber; i >= 1; i--)
        {
            for (int j = 1; j <= secondNumber; j++)
            {
                if (sum >= sumBoundary)
                {
                    isBoundaryPassed = true;
                    break;
                }
                else
                {
                    totalCombinations++;
                    sum += 3 * (i * j);
                }
            }
            if (sum >= sumBoundary)
            {
                isBoundaryPassed = true;
                break;
            }
        }

        Console.WriteLine("{0} combinations", totalCombinations);

        if (isBoundaryPassed)
        {
            Console.WriteLine("Sum: {0} >= {1}", sum, sumBoundary);
        }
        else
        {
            Console.WriteLine("Sum: {0}", sum);
        }
    }
}