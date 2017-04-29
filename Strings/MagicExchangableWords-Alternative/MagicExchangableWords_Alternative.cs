// ** A more effective version, using a dictionary
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

public class MagicExchangableWords_Alternative
{
    public static void Main()
    {
        var inputs = Console.ReadLine()
        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
        .ToArray();

        bool stringsAreEqualLength = false;
        bool stringsAreExchangable = true;

        string firstString = inputs[0];
        string secondString = inputs[1];

        if (firstString.Length == secondString.Length)
        {
            stringsAreEqualLength = true;
            stringsAreExchangable = StringExchangabilityCompare(firstString, secondString);
        }

        if (!stringsAreEqualLength)
        {
            var firstStringCharactersCount = firstString.ToCharArray().Distinct().Count();
            var secondStringCharactersCount = secondString.ToCharArray().Distinct().Count();
            stringsAreExchangable = firstStringCharactersCount == secondStringCharactersCount;
        }

        Console.WriteLine(stringsAreExchangable.ToString().ToLower());
    }

    public static bool StringExchangabilityCompare(string inputStringOne, string inputStringTwo)
    {
        Dictionary<char, char> charExchangeDictionary = new Dictionary<char, char>();

        // The method acceps strings of equal lenghth , which is guaranteed before the method is called within the Main()
        for (int i = 0; i < inputStringOne.Length; i++)
        {
            if (charExchangeDictionary.ContainsKey(inputStringOne[i]))
            {
                if (charExchangeDictionary[inputStringOne[i]] != inputStringTwo[i])
                {
                    return false;
                }
            }
            else
            {
                charExchangeDictionary[inputStringOne[i]] = inputStringTwo[i];
            }
        }

        return true;
    }
}