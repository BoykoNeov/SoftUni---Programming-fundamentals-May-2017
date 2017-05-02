﻿using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Task "Logs Aggregator"
/// You are given a sequence of access logs in format <IP> <user> <duration>. For example:
/// - 192.168.0.11 peter 33
/// - 10.10.17.33 alex 12
/// - 10.10.17.35 peter 30
/// - 10.10.17.34 peter 120
/// - 10.10.17.34 peter 120
/// - 212.50.118.81 alex 46
/// - 212.50.118.81 alex 4
/// Write a program to aggregate the logs data and print for each user the total duration of his sessions
/// and a list of unique IP addresses in format "<user>: <duration> [<IP1>, <IP2>, …]". Order the users
/// alphabetically.Order the IPs alphabetically.In our example, the output should be the following:
/// - alex: 62 [10.10.17.33, 212.50.118.81]
/// - peter: 303 [10.10.17.34, 10.10.17.35, 192.168.0.11]
/// The input comes from the console. At the first line a number n stays which says how many log lines will follow.
/// Each of the next n lines holds a log information in format<IP> <user> <duration>. The input data will
/// always be valid and in the format described.There is no need to check it explicitly.
/// Output:
/// Print one line for each user (order users alphabetically). For each user print its sum 
/// of durations and all of his sessions' IPs, ordered alphabetically in format <user>: <duration>
/// [<IP1>, <IP2>, …]. Remove any duplicated values in the IP addresses and order them alphabetically 
/// (like we order strings).
/// Constraints:
/// - The count of the order lines n is in the range[1…1000].
/// - The<IP> is a standard IP address in format a.b.c.d where a, b, c and d are integers in the range [0…255].
/// - The<user> consists of only of Latin characters, with length of[1…20].
/// - The<duration> is an integer number in the range [1…1000].
/// - Time limit: 0.3 sec.Memory limit: 16 MB.
/// </summary>
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