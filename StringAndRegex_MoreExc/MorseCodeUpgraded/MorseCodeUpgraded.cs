using System;
using System.Text;
using System.Text.RegularExpressions;

/// <summary>
/// You have written new secret way to transmit coded messages. You will receive the input in the format: 
/// {firstLetterOfTheMessage}|{secondLetterOfTheMessage}|…|{nthLetterOfTheMessage}
/// Each part of the message will consist only of ‘0’ and ‘1’. Each part of the message will transform 
/// into a character from the printable range of the ASCII table[32…126(space…~)]. The transformation for each part happens in the following way:
/// Each 0 adds 3 to the total sum.
/// Each 1 adds 5 to the total sum.
/// Every time you receive a sequence of equal digits, the sum increases by the count of the equal digits.
/// The sum should give you the ASCII code of a character.The final message consists of all deciphered signs.
/// Example: 10101010101010101  The message has nine ones and eight zeroes. There are no consecutive equal
/// digits, which means the total is 8 * 3 + 9 * 5 = 69    the letter ‘E’.
/// Example 2: 1110011111111  The message has eleven ones and three zeroes. This sums up to 11 * 5 + 2 * 3 = 61 On top of
/// that we have three sequences with equal digits:
/// The first three digits are ones, so we add 3 to the sum (the current sum equals 61 + 3 = 64)
/// The next two digits are zeroes, so we add 2 to the sum(the current sum equals 64 + 2 = 66)
/// The next eight digits are ones, so we add 8 to the sum(the current sum equals 66 + 8 = 74). 
/// We reached the end of the string, and the final ASCII code is 74 ‘J’.
/// Input
/// You will receive a single line with the letters from the message.They will be separated with single pipe – ‘|’
/// Output
/// Print only the deciphered message.
/// Constraints
/// Each coded letter will consist of either ‘1’ or ‘0’.
/// The ASCII codes will be in the interval [32…126].
/// </summary>
public class MorseCodeUpgraded
{
    public static void Main()
    {
        StringBuilder outputSb = new StringBuilder();

        string[] input = Console.ReadLine().Split('|');
        string pattern = @"(1{2,})|(0{2,})";

        Regex regex = new Regex(pattern);

        foreach (string encodedChar in input)
        {
            var matches = regex.Matches(encodedChar);

            char character = (char)0;

            foreach(char oneOrZero in encodedChar)
            {
                if (oneOrZero == '0')
                {
                    character += (char)3;
                }
                else if (oneOrZero == '1')
                {
                    character += (char)5;
                }
            }

            foreach (Match match in matches)
            {
                character += (char)match.Value.Length;
            }

            outputSb.Append(character);
        }

        Console.WriteLine(outputSb.ToString());
    }
}