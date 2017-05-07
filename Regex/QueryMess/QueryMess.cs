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
    using System.Linq;

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
                var inputLines = consoleInput.Split(new char[] { '&' }, StringSplitOptions.RemoveEmptyEntries);
                Dictionary<string, string> queries = new Dictionary<string, string>();

                foreach (string inputLine in inputLines)
                {
                    List<string> queryInput = inputLine.
                        Split(new char[] { '=', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                    
                        // must revork this section to split for '?' and check if contains '='
                    if (queries.ContainsKey(queryInput[0]))
                    {
                        string tempQueryKey = queryInput[0];
                        string tempQueryValue = queries[queryInput[0]];
                        queryInput.RemoveAt(0);
                        queryInput.Insert(0, tempQueryValue);
                        tempQueryValue = string.Join(", ", queryInput);
                        queries[tempQueryKey] = tempQueryValue;
                    }
                    else
                    {
                        string tempQueryKey = queryInput[0];
                        queryInput.RemoveAt(0);
                        string tempQueryValue = string.Join(" ,", queryInput);
                        queries[tempQueryKey] = tempQueryValue;
                    }
                }

                foreach (var kvp in queries)
                {
                    Console.Write($"{kvp.Key}=[{kvp.Value}]");
                }
                Console.WriteLine();
            }
        }
    }
}
