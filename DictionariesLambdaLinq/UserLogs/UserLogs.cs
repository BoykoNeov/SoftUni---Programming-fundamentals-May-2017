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

            //if (!input.Contains("user"))
            //{
            //    input.AddRange(Console.ReadLine().Split(new char[] { '=', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList());
            //}

            string username = string.Empty;
            string ip = string.Empty;

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] == "IP")
                {
                    ip = input[i + 1];
                }

                if (input[i] == "user")
                {
                    username = input[i + 1];
                }
            }

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

        foreach (KeyValuePair<string, List<string>> kvp in UserLogs)
        {
            Console.WriteLine($"{kvp.Key}:");
            int ipCount = 0;
            List<string> consoleIpOutput = new List<string>();

            for (int j = 0; j < kvp.Value.Count; j++)
            {
                for (int i = 0; i < kvp.Value.Count; i++)
                {
                    if (kvp.Value[0] == kvp.Value[i])
                    {
                        ipCount++;
                    }
                }
                consoleIpOutput.Add(string.Format($"{kvp.Value[0]} => {ipCount}"));
                kvp.Value.RemoveAll(item => item == kvp.Value[0]);
                j = -1;
                ipCount = 0;
            }
            Console.WriteLine(string.Join(", ", consoleIpOutput) + ".");
        }
    }
}