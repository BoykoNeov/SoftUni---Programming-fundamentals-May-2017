/// <summary>
/// Almost the same task as from programming basics exam on 18-Mar-2017
/// </summary>
using System;
public class GameOfNumbers
{
    public static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int magicNumber = int.Parse(Console.ReadLine());
        int combinationNumber = 0;
        bool magicFound = false;

        for (int i = firstNumber; i <= secondNumber; i++)
        {
            for (int j = firstNumber; j <= secondNumber; j++)
            {
                combinationNumber++;
                if (i + j == magicNumber && magicFound == false)
                {
                    magicFound = true;
                    Console.Write($"Number found! {j} + {i} = {i + j}");
                }
            }
        }

        if (magicFound == false)
        {
            Console.WriteLine($"{combinationNumber} combinations - neither equals {magicNumber}");
        }
    }
}