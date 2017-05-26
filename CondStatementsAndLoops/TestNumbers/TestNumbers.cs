using System;
public class TestNumbers
{
    static void Main()
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