using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Task "Srabsko Unleashed"
/// On each input line you’ll be given data in format: "singer @venue ticketsPrice ticketsCount". There will be no redundant whitespaces anywhere in the input. Aggregate the data by venue and by singer. For each venue, print the singer and the total amount of money his/her concerts have made on a separate line. Venues should be kept in the same order they were entered; the singers should be sorted by how much money they have made in descending order. If two singers have made the same amount of money, keep them in the order in which they were entered. 
/// Keep in mind that if a line is in incorrect format, it should be skipped and its data should not be added to the output.Each of the four tokens must be separated by a space, everything else is invalid.The venue should be denoted with @ in front of it, such as @Sunny Beach
/// SKIP THOSE: Ceca @Belgrade125 12378, Ceca @Belgrade12312 123
/// The singer and town name may consist of one to three words.
/// Input
/// - The input data should be read from the console.
/// - It consists of a variable number of lines and ends when the command “End" is received.
/// - The input data will always be valid and in the format described.There is no need to check it explicitly.
///  Output:
/// - The output should be printed on the console.
/// - Print the aggregated data for each venue and singer in the format shown below.
/// - Format for singer lines is { 2space}{singer}{space}->{space}{total money}
/// Constraints
/// - The number of input lines will be in the range[2 … 50].
/// - The ticket price will be an integer in the range[0 … 200].
/// - The ticket count will be an integer in the range[0 … 100 000]
/// - Singers and venues are case sensitive
/// - Allowed working time for your program: 0.1 seconds.Allowed memory: 16 MB.
/// </summary>
public class SrabskoUnleashed
{
    public static void Main()
    {
        var venuesSingersMoney = new Dictionary<string, Dictionary<string, long>>();

        while (true)
        {
            string inputString = Console.ReadLine();
            if (inputString == "End")
            {
                break;
            }

            // skip this input line if it contains any charachters except '@'
            if (inputString.IndexOfAny(@"!~#$%^&*()_+<>?/|/""\:;`'".ToCharArray()) != -1)
            {
                continue;
            }

            var rawInputList = inputString.Split(new char[] { ' ' }).ToList();

            // check if input contains two or more inputs
            bool invalidInput = false;
            for (int i = 0; i < rawInputList.Count - 1; i++)
            {
                if (rawInputList[i] == string.Empty && rawInputList[i + 1] == string.Empty)
                {
                    invalidInput = true;
                }
            }

            if (invalidInput)
            {
                continue;
            }

            // Remove all empty spaces and transfer the items to a new list "input"
            List<string> input = new List<string>();
            foreach (string item in rawInputList)
            {
                if (item != string.Empty)
                {
                    input.Add(item);
                }
            }

            int ticketsPrice = 0;
            int ticketsCount = 0;

            // A bit redundant, but to avoid possible exceptions in the next check
            if (input.Count < 4)
            {
                continue;
            }

            if (!int.TryParse(input[input.Count - 1], out ticketsCount) ||
                !int.TryParse(input[input.Count - 2], out ticketsPrice))
            {
                continue;
            }

            // Variables already transfered to ticketPrice and ticketCount
            input.RemoveAt(input.Count - 1);
            input.RemoveAt(input.Count - 1);

            // check if there is an input string which starts with '@'
            invalidInput = true;
            foreach (string item in input)
            {
                if (item[0] == '@')
                {
                    invalidInput = false;
                    break;
                }
            }

            if (invalidInput)
            {
                continue;
            }

            string singerName = string.Empty;
            string venueName = string.Empty;
            int venueNameLength = 1;

            // construct venue name
            for (int i = 0; i < input.Count; i++)
            {
                string word = input[i];
                if (word[0] == '@')
                {
                    venueName = word.Remove(0, 1);
                    for (int j = i + 1; j < input.Count; j++)
                    {
                        venueName += " " + input[j];
                        venueNameLength++;
                    }

                    input.RemoveRange(i, venueNameLength);
                }
            }

            // another check for valid input
            if (venueNameLength > 3 ||
                input.Count > 3 ||
                input.Count == 0)
            {
                continue;
            }

            // construct singer name
            singerName = string.Join(" ", input);

            // add to dictionary
            if (!venuesSingersMoney.ContainsKey(venueName))
            {
                venuesSingersMoney[venueName] = new Dictionary<string, long>();
            }

            if (!venuesSingersMoney[venueName].ContainsKey(singerName))
            {
                venuesSingersMoney[venueName][singerName] = ticketsCount * ticketsPrice;
            }
            else
            {
                venuesSingersMoney[venueName][singerName] += ticketsPrice * ticketsCount;
            }
        }

        // Print results
        foreach (var venue in venuesSingersMoney)
        {
            Console.WriteLine(venue.Key);
            foreach (var singer in venuesSingersMoney[venue.Key].OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"#  {singer.Key} -> {singer.Value }");
            }
        }
    }
}