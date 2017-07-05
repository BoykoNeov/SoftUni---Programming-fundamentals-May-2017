using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

/// <summary>
/// You will be given information about results of football matches.
/// Create a standings table by points. For win the team gets 3 points, 
/// for loss – 0 and for draw – 1. Also find the top 3 teams with most scored
/// goals in descending order. If two or more teams are with same goals scored or same points order them by name in ascending order.
/// The name of each team is encrypted.You must decrypt it before proceeding 
/// with calculating statistics.You will be given some string key and the team name will be placed between that key in reversed order.
/// For example: the key: “???”;
/// String to decrypt: “kfle??? airagluB??? gertIt%%” -> “airagluB” -> “Bulgaria”
/// Also you should ignore the letter casing in the team names.For example:
/// buLgariA = BulGAria = bulGARIA = BULGARIA
/// Input / Constrains
/// On the first line of input you will get the key that will be used for decryption
/// On the next lines until you receive “final” you will get lines in format:
/// {encrypted teamA} {encrypted teamB} {teamA score}:{teamB score}
/// Team scores will be integer numbers in the range[0...231]
/// Output
/// Print the standings table ordered descending by points in format:
/// Where place is a number in range[1… number of teams].
/// Then you should print the top 3 team ordered by goals in descending order in format:
/// All team’s names should be uppercase.
/// For more clarification, see the examples on the next page.
/// </summary>
public class FootballStandings
{
    public static void Main()
    {
        string key = Console.ReadLine();
        // string pattern = @"(?<=(\Q??\E)).+?(?=(\Q??\E))";
        string regexPattern = Regex.Escape(key) + @"\w*?" + Regex.Escape(key);
        string resultRegexPattern = @"(\d+):(\d+)";

        string input = string.Empty;
        Dictionary<string, long> teamsStandings = new Dictionary<string, long>();
        Dictionary<string, long> teamsGoals = new Dictionary<string, long>();

        while ((input = Console.ReadLine()) != "final")
        {
            MatchCollection teamsMatch = Regex.Matches(input, regexPattern);
            Match goals = Regex.Match(input, resultRegexPattern);

            List<string> teams = new List<string>();

            foreach (Match match in teamsMatch)
            {
                string temp = match.Value.ToString();
                temp = temp.Replace(key, "");
                temp = temp.ToUpper();
                teams.Add(Reverse(temp));
            }

            long[] result = new long[2];

            result[0] = long.Parse(goals.Groups[1].Value.ToString());
            result[1] = long.Parse(goals.Groups[2].Value.ToString());

            if (!teamsGoals.ContainsKey(teams[0]))
            {
                teamsGoals.Add(teams[0], 0);
            }

            if (!teamsGoals.ContainsKey(teams[1]))
            {
                teamsGoals.Add(teams[1], 0);
            }

            if (!teamsStandings.ContainsKey(teams[0]))
            {
                teamsStandings.Add(teams[0], 0);
            }

            if (!teamsStandings.ContainsKey(teams[1]))
            {
                teamsStandings.Add(teams[1], 0);
            }

            teamsGoals[teams[0]] += result[0];
            teamsGoals[teams[1]] += result[1];

            if (result[0] > result[1])
            {
                teamsStandings[teams[0]] += 3;
            }
            else if(result[0] < result[1])
            {
                teamsStandings[teams[1]] += 3;
            }
            else
            {
                teamsStandings[teams[0]] += 1;
                teamsStandings[teams[1]] += 1;
            }
        }

        int teamsByStandingsCounter = 1;
        Console.WriteLine("League standings:");

        foreach (KeyValuePair<string, long> byScore in teamsStandings.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
        {
            Console.WriteLine($"{teamsByStandingsCounter++}. {byScore.Key} {byScore.Value}");
        }

        int teamsByGoalsCounter = 0;
        Console.WriteLine("Top 3 scored goals:");

        foreach (KeyValuePair<string, long> byGoals in teamsGoals.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
        {
            if (teamsByGoalsCounter++ == 3)
            {
                break;
            }

            Console.WriteLine($"- {byGoals.Key} -> {byGoals.Value}");
        }
    }

    public static string Reverse(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}