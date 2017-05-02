using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// You are given an input in the format:
/// IP=(IP.Address) message=(A&sample&message) user=(username)
/// Your task is to parse the IP and the username from the input and for every user, you have to display
/// every IP from which the corresponding user has sent a message and the count of the messages
/// sent with the corresponding IP.In the output, the usernames must be sorted alphabetically while 
/// their IP addresses should be displayed in the order of their first appearance.The output should 
/// be in the following format:
/// username:
/// IP => count, IP => count.
/// For example, given the following input - IP= 192.23.30.40 message= 'Hello&derps.' user= destroyer,
/// you have to get the username destroyer and the IP 192.23.30.40 and display it in the following format:
/// destroyer: 
/// 192.23.30.40 => 1.
/// The username destroyer has sent a message from IP 192.23.30.40 once.
/// Check the examples below. They will further clarify the assignment.
/// Input:
/// The input comes from the console as varying number of lines. You have to parse every command
/// until the command that follows is end.The input will be in the format displayed above,
/// there is no need to check it explicitly.
/// Output:
/// For every user found, you have to display each log in the format:
/// username: 
/// IP => count, IP => count…
/// The IP addresses must be split with a comma, and each line of IP addresses must end with a dot.
/// Constraints:
/// - The number of commands will be in the range [1..50]
/// - The IP addresses will be in the format of either IPv4 or IPv6.
/// - The messages will be in the format: This&is&a&message
/// - The username will be a string with length in the range [3..50]
/// - Time limit: 0.3 sec.Memory limit: 16 MB.
/// </summary>
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