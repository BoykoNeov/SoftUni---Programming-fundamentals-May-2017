// Task MagicExchangableWords. Write a method that takes as input two strings, and returns Boolean if 
// they are exchangeable or not. Exchangeable are words where the characters in the first string can be replaced 
// to get the second string. Example: "egg" and "add" are exchangeable, but "aabbccbb" and "nnooppzz" are not. 
// (First 'b' corresponds to 'o', but then it also corresponds to 'z'). The two words may not have the same length, 
// if such is the case they are exchangeable only if the longer one doesn't have more types of characters then the 
// shorter one ("Clint" and "Eastwaat" are exchangeable because 'a' and 't' are already mapped as 'l' and 'n', but
// "Clint" and "Eastwood" aren't exchangeable because 'o' and 'd' are not contained in "Clint").

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MagicExchangableWords
{
    public static void Main()
    {
        var inputs = Console.ReadLine()
        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
        .ToArray();

        bool stringsAreEqualLength = false;
        bool stringsAreExchangable = false;

        string firstString = inputs[0];
        string secondString = inputs[1];

        if (firstString.Length == secondString.Length)
        {
            stringsAreEqualLength = true;
            string tempString = string.Empty;

            for (int i = 0; i < firstString.Length; i++)
            {
                tempString = firstString.Replace(firstString[i], secondString[i]);
            }

            if (tempString == secondString)
            {
                stringsAreExchangable = true;
            }
        }

        if (!stringsAreEqualLength)
        {
            var firstStringCharactersCount = firstString.ToCharArray().Distinct().Count();
            var secondStringCharactersCount = secondString.ToCharArray().Distinct().Count();

            stringsAreExchangable = (firstStringCharactersCount == secondStringCharactersCount);
        }

        Console.WriteLine(stringsAreExchangable);
    }
}