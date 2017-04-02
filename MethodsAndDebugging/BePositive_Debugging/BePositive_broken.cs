//Soft uni debugging excercise from Programing Fundamentals - Methods and debugging

using System;
using System.Collections.Generic;

public class BePositive_broken
{
    public static void Main()
    {
        int countSequences = int.Parse(Console.ReadLine());

        for (int i = 0; i < countSequences; i++)
        {
            string[] input = Console.ReadLine().Split(' ');

            var numbers = new List<int>();

            foreach (string number in input)
            {
                if (!string.IsNullOrEmpty(number))
                {
                    numbers.Add(int.Parse(number));
                }
            }

            bool found = false;

            for (int j = 0; j < numbers.Count; j++)
            {
                int currentNum = numbers[j];

                if (currentNum >= 0)
                {
                    if (found)
                    {
                        Console.Write(" ");
                    }

                    Console.Write(currentNum);
                    found = true;
                }
                else if (!(j >= numbers.Count - 1))
                {
                    //if (j >= numbers.Count - 1)
                    //{
                    //    break;
                    //}
                    currentNum += numbers[j + 1];

                    if (currentNum >= 0)
                    {
                        if (found)
                        {
                            Console.Write(" ");
                        }

                        Console.Write(currentNum);
                        found = true;
                        j++;
                    }
                    else
                    {
                        j++;
                    }

                }
                if ((j == numbers.Count - 1) && found == true)
                {
                    Console.WriteLine();
                }
            }

            if (!found)
            {
                Console.WriteLine("(empty)");
            }
        }
    }
}