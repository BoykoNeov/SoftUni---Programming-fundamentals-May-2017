/// <summary>
/// Write a program to extract all email addresses from a given text. The text comes at the only input line.
/// Print the emails on the console, each at a separate line. Emails are considered to be in format <user>@<host>, where: 
/// <user> is a sequence of letters and digits, where '.', '-' and '_' can appear between them.Examples of
/// valid users: "stephan", "mike03", "s.johnson", "st_steward", "softuni-bulgaria", "12345". Examples of invalid users: ''--123", ".....", "nakov_-", "_steve", ".info". 
/// <host> is a sequence of at least two words, separated by dots '.'. Each word is sequence of letters
/// and can have hyphens '-' between the letters.Examples of hosts: "softuni.bg", "software-university.com",
/// "intoprogramming.info", "mail.softuni.org". Examples of invalid hosts: "helloworld", ".unknown.soft.", "invalid-host-", "invalid-". 
/// Examples of valid emails: info @softuni-bulgaria.org, kiki @hotmail.co.uk, no-reply @github.com,
/// s.peterson @mail.uu.net, info-bg @software-university.software.academy.
/// Examples of invalid emails: --123@gmail.com, …@mail.bg, .info @info.info, _steve @yahoo.cn, mike @helloworld, mike@.unknown.soft., s.johnson @invalid-.
/// </summary>
namespace ExtractEmails
{
    using System;
    using System.Text.RegularExpressions;

    public class ExtractEmails
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            // first unsuccesfful pattern = (@"[\s|\n\r\t]([a-zA-Z0-9]+[.\-_]?[a-zA-Z0-9]+)@[a-zA-Z0-9]+([\-|\.][a-zA-Z0-9]+)+[\s]");
            // pattern from fellow studetns for guidance = @"\b(?<!\S)[a-z][a-z0-9\.\-_]+[a-z0-9]*@[a-z][a-z\-]+\.[a-z][a-z\.]+[a-z]?\b";

            // Assert that the Regex below does not match - "\S" - matches any non-whitespace character(equal to[^\r\n\t\f])
            // the negative lookbehind "(?<!\S)" in the beginning serves to
            // certify that the email does not start with '_' or similar characters
            string pattern = @"\b(?<!\S)[a-z0-9]+([\.\-_]|[a-z0-9]+)+[a-z0-9]*@([a-z]+[\-|\.])+[a-z]+\b";

            Regex emailsRegex = new Regex(pattern);

            var matches = emailsRegex.Matches(input);
            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
            Console.WriteLine();
        }
    }
}