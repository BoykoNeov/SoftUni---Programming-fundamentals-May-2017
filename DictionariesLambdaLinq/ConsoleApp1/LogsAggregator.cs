// Task Logs Aggregator 
// Check the file ../06. Programming-Fundamentals-Dictionaries-Lambda-LINQ-Exercises for task description

using System;
using System.Collections.Generic;
using System.Linq;

public class LogsAggregator
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var usersMinutes = new Dictionary<string, int>();
        var usersIPs = new Dictionary<string, HashSet<string>>();

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            if (!usersMinutes.ContainsKey(input[1]))
            {
                usersMinutes.Add(input[1], int.Parse(input[2]));
                usersIPs.Add(input[1], new HashSet<string>());
                usersIPs[input[1]].Add(input[0]);
            }
            else
            {
                usersMinutes[input[1]] += int.Parse(input[2]);
                usersIPs[input[1]].Add(input[0]);
            }
        }

        foreach (var kvpUsersMinutes in usersMinutes.OrderBy(x => x.Key))
        {
            string output = string.Format($"{kvpUsersMinutes.Key}: {kvpUsersMinutes.Value} ");
            output += string.Format($"[{string.Join(", ", usersIPs[kvpUsersMinutes.Key].OrderBy(x => x))}]");
            Console.WriteLine(output);
        }
    }
}