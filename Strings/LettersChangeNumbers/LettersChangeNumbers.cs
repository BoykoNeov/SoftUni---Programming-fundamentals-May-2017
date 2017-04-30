/// <summary>
///  You get a string consisting of a number between two letters. Depending on whether the letter was in front of the number or after it you would perform different mathematical operations on the number to achieve the result. 
///  First you start with the letter before the number.If it's Uppercase you divide the number by the letter's position in the alphabet.
///  If it's lowercase you multiply the number with the letter's position. Then you move to the letter after the number.
///  If it's Uppercase you subtract its position from the resulted number. If it's lowercase you add its position to the resulted number.
///  He decided to complicate it a bit by doing the same but with multiple strings keeping track of only the total sum of all results.
/// </summary>
namespace LettersChangeNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LettersChangeNumbers
    {
        public static void Main()
        {
            string[] alphabet = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            Dictionary<string, int> letterPositions = new Dictionary<string, int>();

            for (int i = 1; i <= alphabet.Length; i++)
            {
                letterPositions[alphabet[i - 1]] = i;
            }

            // A really stupid trick on the side of the problem inventor with this '\t', as was said in the forum "Haide da preebem kursistite"
            string[] inputs = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            double resultTotal = 0;

            for (int i = 0; i < inputs.Length; i++)
            {
                string combination = new string(inputs[i].ToCharArray());

                string firstLetter = (combination[0]).ToString();
                string lastLetter = combination[combination.Length - 1].ToString();

                string tempString = new string(combination.ToCharArray());
                tempString = tempString.Remove(0, 1);
                tempString = tempString.Remove(tempString.Length - 1, 1);

                double number = double.Parse(tempString);

                double currentCombinationResult = 0;

                if (firstLetter == firstLetter.ToLower())
                {
                    currentCombinationResult = letterPositions[firstLetter] * number;
                }
                else
                {
                    firstLetter = firstLetter.ToLower();
                    currentCombinationResult = number / letterPositions[firstLetter];
                }

                if (lastLetter == lastLetter.ToLower())
                {
                    currentCombinationResult += letterPositions[lastLetter];
                }
                else
                {
                    lastLetter = lastLetter.ToLower();
                    currentCombinationResult -= letterPositions[lastLetter];
                }

                resultTotal += currentCombinationResult;
            }

            Console.WriteLine($"{ resultTotal:f2}");
        }
    }
}