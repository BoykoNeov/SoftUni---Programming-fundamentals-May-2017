/// <summary>
/// Input:
/// The input comes from the console on a variable number of lines and ends when the keyword "END" is received.
/// For each row of the input, the query string contains pairs field = value.Within each pair, the field name and value are separated by an equals sign, '='. The series of pairs are separated by an ampersand, '&'. The question mark is used as a separator and is not part of the query string. A URL query string may contain another URL as value.The input data will always be valid and in the format described.There is no need to check it explicitly.
/// Output:
/// For each input line, print on the console a line containing the processed string as follows:  key=[value]nextkey=[another  value] … etc.
/// Multiple whitespace characters should be reduced to one inside value/key names, but there shouldn’t be any whitespaces before/after extracted keys and values.If a key already exists, the value is added with comma and space after other values of the existing key in the current string.  See the examples below.  
/// Constraints:
/// SPACE is encoded as '+' or "%20". Letters (A-Z and a-z), numbers(0-9), the characters '*', '-', '.', '_' and other non-special symbols are left as-is.
/// </summary>
namespace QueryMess
{
    using System;
    using System.Text.RegularExpressions;
    using System.Collections.Generic;

    public class QueryMess
    {
        public static void Main()
        {
            string consoleInput = string.Empty;
            while ((consoleInput = Console.ReadLine()) != "END")
            {
                string whitespacesEncoding = @"((%20)|\+)+";
                Regex emptySpaces = new Regex(whitespacesEncoding);
                consoleInput = emptySpaces.Replace(consoleInput, " ");

                string queriesPattern = @"([^&?\n=]+)=([^&?\n=]+)";
                Regex queriesRegex = new Regex(queriesPattern);
                MatchCollection matches = queriesRegex.Matches(consoleInput);

                Dictionary<string, List<string>> queries = new Dictionary<string, List<string>>();

                foreach (Match match in matches)
                {
                    string queryKey = match.Groups[1].Value.Trim();
                    string queryValues = match.Groups[2].Value.Trim();

                    if (!queries.ContainsKey(queryKey))
                    {
                        queries[queryKey] = new List<string>();
                    }

                    queries[queryKey].Add(queryValues);
                }

                foreach (KeyValuePair<string, List<string>> currentQueryOutput in queries)
                {
                    string queryValueOutput = string.Join(", ", currentQueryOutput.Value);
                    Console.Write($"{currentQueryOutput.Key}=[{queryValueOutput}]");
                }

                Console.WriteLine();
            }
        }
    }
}
