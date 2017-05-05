/// <summary>
/// Write a program that extracts from a text all sentences that contain a particular word (case-sensitive).
///	Assume that the sentences are separated from each other by the character "." or "!" or "?".
///	The words are separated one from another by a non-letter character.
/// Notе that appearance as substring is different than appearance as word.The sentence “I am a fan of Motorhead” does not contain the word “to”. It contains the substring “to” which is not what we need.
///	Print the result sentence text without the separators between the sentences ("." or "!" or "?").
/// </summary>
namespace ExtractSentencesByKeyword
{
    using System;
    using System.Text.RegularExpressions;

    public class ExtractSentencesByKeyword
    {
        public static void Main()
        {
            string keyword = Console.ReadLine();
            string inputText = Console.ReadLine();

            string regexFirstPart = @"\w[^.!?]*\b";
            string regexSecondPart = @"\b[^.!?]*(?=[.!?])";

            string regexString = string.Concat(regexFirstPart,keyword,regexSecondPart);
            Regex keywordRegex = new Regex(regexString);

            var matches = keywordRegex.Matches(inputText);
            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}