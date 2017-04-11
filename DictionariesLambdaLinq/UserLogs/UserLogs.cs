// Task "User Logs"
// Check the file ../06. Programming-Fundamentals-Dictionaries-Lambda-LINQ-Exercises for task description

using System;
using System.Collections.Generic;
using System.Linq;

public class UserLogs
{
    public static void Main()
    {
        var UserLogs = new SortedDictionary<string, List<string>>();

        while (true)
        {
            List<string> input = Console.ReadLine().Split(new char[] { '=', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            if (input[0] == "end")
            {
                break;
            }

            string username = string.Empty;
            string ip = string.Empty;

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] == "IP")
                {
                    // Since the input string are separated for '=' also, the IP addres is the next list entry after "IP"
                    ip = input[i + 1];
                }

                if (input[i] == "user")
                {
                    // Since the input string are separated for '=' also, the username addres is the next list entry after "user"
                    username = input[i + 1];
                }
            }

            // add all IPs to the dictionary of lists with the username as key
            if (UserLogs.ContainsKey(username))
            {
                UserLogs[username].Add(ip);
            }
            else
            {
                UserLogs.Add(username, new List<string>());
                UserLogs[username].Add(ip);
            }
        }

        // run through the dictionary of lists and count the occurencies of each unique string (ip) and 
        // add them to a new dictionary <string,int> for the final output (unique IPs as keys in the final dict)
        foreach (KeyValuePair<string, List<string>> kvp in UserLogs)
        {
            Console.WriteLine($"{kvp.Key}:");

            // list for constructing the Console output for each unique IP
            List<string> consoleIpOutput = new List<string>();

            Dictionary<string, int> ipCount = new Dictionary<string, int>();

            for (int i = 0; i < kvp.Value.Count; i++)
            {
                if (ipCount.ContainsKey(kvp.Value[i]))
                {
                    ipCount[kvp.Value[i]] = ipCount[kvp.Value[i]] + 1;
                }
                else
                {
                    ipCount.Add(kvp.Value[i], 1);
                }
            }

            foreach (var internalKvp in ipCount)
            {
                consoleIpOutput.Add(string.Format($"{internalKvp.Key} => {internalKvp.Value}"));
            }

            Console.WriteLine(string.Join(", ", consoleIpOutput) + ".");
        }
    }
}