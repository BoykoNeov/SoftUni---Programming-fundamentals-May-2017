/// <summary>
/// Write a program that replaces in a HTML document given as string all the tags <a href=…>…</a> 
/// with corresponding tags [URL href=…>…[/URL]. Read an input, until you receive “end” command. Print the result on the console. 
/// </summary>
namespace ReplaceATag
{
    using System;
    using System.Text.RegularExpressions;

    class ReplaceATag
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            string HTMLdocument = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                HTMLdocument = input;

                Regex HTMLtags = new Regex(@"(<a ?)(.+)(>)(.+)(<\/a>)");
                Match match = HTMLtags.Match(HTMLdocument);

                //   Console.WriteLine(match.Groups[2].Value);
                string output = HTMLtags.Replace(HTMLdocument, @"[URL $2]$4[/URL]");
                Console.WriteLine(output);
            }
        }
    }
}