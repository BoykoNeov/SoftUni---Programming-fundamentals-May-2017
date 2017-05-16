﻿/// <summary>
/// You are assigned to sign in all the participants in the nether realm's mighty battle's
/// demon book, which of course is sorted alphabetically. 
/// A demon's name contains his health and his damage. 
/// The sum of the asci codes of all characters(excluding numbers (0-9),
/// arithmetic symbols('+', '-', '*', '/') and delimiter dot('.')) gives a demon's total health. 
/// The sum of all numbers in his name forms his base damage.Note that you should
/// consider the plus '+' and minus '-' signs(e.g. +10 is 10 and -10 is -10). 
/// However, there are some symbols('*' and '/') that can further alter the base
/// damage by multiplying or dividing it by 2 (e.g. in the name "m15*/c-5.0", the base
/// damage is 15 + (-5.0) = 10 and then you need to multiply it by 2 (e.g. 10 * 2 = 20)
/// and then divide it by 2 (e.g. 20 / 2 = 10)). 
/// So, multiplication and division are applied only after all numbers are included 
/// in the calculation and in the order they appear in the name.
/// You will get all demons on a single line, separated by commas and zero or more 
/// blank spaces.Sort them in alphabetical order and print their names along their health and damage.
/// Input
/// The input will be read from the console.The input consists of a single line 
/// containing all demon names separated by commas and zero or more spaces in the format:
/// "{demon name}, {demon name}, … {demon name}"
/// Output
/// Print all demons sorted by their name in ascending order, each on a separate line in the format:
/// "{demon name} - {health points} health, {damage points} damage"
/// Constraints
/// A demon's name will contain at least one character
/// A demon's name cannot contain blank spaces ' ' or commas ','
/// A floating point number will always have digits before and after its decimal separator
/// Number in a demon's name is considered everything that is a valid integer
/// or floating point number (with dot '.' used as separator). For example, all these
/// are valid numbers: '4', '+4', '-4', '3.5', '+3.5', '-3.5' 
/// </summary>
namespace NetherRealms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class NetherRealms
    {
        public static void Main()
        {
            string[] demonNames = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, double[]> demons = new Dictionary<string, double[]>();

            Regex multiplyOrDivideRegex = new Regex(@"(\*|\/)\1*"); // pattern for matching '*' and '/'

            foreach (string demon in demonNames)
            {
                Regex lettersRegex = new Regex(@"[^\d+\-*\/\.]+"); //pattern for selecting everything except digits and special symbols)
                MatchCollection letters = lettersRegex.Matches(demon);
                int demonHealth = 0;
                foreach (Match match in letters)
                {
                    foreach (char letter in match.ToString())
                    {
                        demonHealth += letter;
                    }
                }

                demons[demon][0] = demonHealth;

                Regex digitsRegex = new Regex(@"[+|-]?\d+\.?\d*"); // pattern for selecting digits)

            }
        }
    }
}