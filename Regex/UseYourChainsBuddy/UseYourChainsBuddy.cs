/// <summary>
///  *Use Your Chains, Buddy
/// This problem is from the JavaScript Basics Exam(9 January 2015). You may check your solution here.
/// You are in Cherny Vit now and there are 12km to Anchova Bichkiya Hut.You need to get there by car.But there is so much snow that you need to use car chains. In order to put them on the wheels correctly, you need to read the manual. But it is encrypted…
/// As input you will receive an HTML document as a single string. You need to get the text from all the<p> tags and replace all characters which are not small letters and numbers with a space " ". After that you must decrypt the text – all letters from a to m are converted to letters from n to z (a  n; b  o; … m  z). The letters from n to z are converted to letters from a to m(n  a; o  b; … z  m). All multiple spaces should then be replaced by only one space.
/// For example, if we have "<div>Santa</div><p>znahny # grkg ()&^^^&12</p>" we extract "znahny # grkg ()&^^^&12". Every character that is not a small letter or a number is replaced with a space("znahny grkg       12"). We convert each small letter as described above("znahny grkg       12"  "manual text       12") and replace all multiple spaces with only one space("manual text 12"). Finally, we concatenate the decrypted text from all<p></p> tags(in this case, it's only one). And there you go – you have the manual ready to read!
/// Input:
/// The input is read from the console and consists of just one line – the string with the HTML document.
/// The input data will always be valid and in the format described.There is no need to check it explicitly.
/// Output:
/// Print on a single line the decrypted text of the manual. See the given examples below.
/// Constraints:
///	Allowed working time: 0.2 seconds. Allowed memory: 16 MB
/// </summary>
namespace UseYourChainsBuddy
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    public class UseYourChainsBuddy
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Regex pTags = new Regex(@"(?<=<p>).*?(?=<\/p>)");
            MatchCollection matches = pTags.Matches(input);
            StringBuilder afterPtagsMatch = new StringBuilder();
            foreach (Match match in matches)
            {
                afterPtagsMatch.Append(match);
                afterPtagsMatch.Append(string.Empty);
            }

            Regex nonSmallLettersOrNumbers = new Regex(@"[^a-z0-9]+");
            string afterReplacingNonSmallLettersOrNumbers = nonSmallLettersOrNumbers
                .Replace(afterPtagsMatch.ToString(), " ");

            // English alphabet has 26 symbols
            char[] alphabet = new char[26];
            alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            StringBuilder afterDecoding = new StringBuilder(afterReplacingNonSmallLettersOrNumbers.Length);

            for (int i = 0; i < afterReplacingNonSmallLettersOrNumbers.Length; i++)
            {
                char currentChar = afterReplacingNonSmallLettersOrNumbers[i];

                if (currentChar >= 'a' && currentChar <= 'm')
                {
                    afterDecoding.Append((char)(currentChar + 13));
                }
                else if (currentChar >= 'n' && currentChar <= 'z')
                {
                    afterDecoding.Append((char)(currentChar - 13));
                }
                else
                {
                    afterDecoding.Append(currentChar);
                }
            }

            string[] output = afterDecoding.ToString()
                .ToString()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine(string.Join(" ", output));
        }
    }
}