/// <summary>
/// On the first line , you will receive a list with all participants that applied for performance.
/// On the second line, you will receive the list with all available songs.
/// On the next lines , until the " dawn" command , you will get the names of people , the song that they are performing on stage and the award they get from the audience.
/// However, not every time the plan goes according to schedule.In other words, everyone (listed or not) can go on stage and perform a song that is not even available and he still gets awards from the audience.However, you should record only the awards for listed participants that perform songs available in the list.In case someone is not listed or sings a song that is not available you should not record neither the participant, nor his award.
/// When the "dawn" comes, you need to print all participants, the count of the unique awards they received and all unique awards. Participants should be sorted by number of awards in descending order and then by participant name alphabetically. Awards should be sorted in alphabetical order.
/// Input
/// On the first line, you will receive list with all participants that applied for performance in the format: "{participant}, {participant} … {participant}"
/// On the second line, you will get all available songs in the in the format: "{song}, {song} … {song}"
/// On the next lines, until the "dawn" command you will receive every stage performance in the format: "{participant}, {song}, {award}"
/// Performances and songs will be separated by a comma and a single or multiple white spaces
/// Output
/// Print all participants along with the number of unique awards they won in the format:
/// oo**"{participant}: {award count} awards"**
/// oo**"--{award}"**
/// Print participants sorted by unique awards count in descending order. If two participants have the same unique award count , sort them alphabetically by name
/// Print unique awards for every participant sorted alphabetically
/// If there are no awards, print "No awards"
/// </summary>
namespace SoftUniKaraoke
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SoftUniKaraoke
    {
        public static void Main()
        {
            string[] participantsInput = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();

            // The initial version worked with lists of participants and songs, but it is faster with hashsets
            HashSet<string> participants = new HashSet<string>();
            foreach (string participant in participantsInput)
            {
                participants.Add(participant);
            }

            string[] songsInput = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                                .Select(x => x.Trim())
                                .ToArray();

            HashSet<string> songs = new HashSet<string>();
            foreach (string song in songsInput)
            {
                songs.Add(song);
            }

            var properlyGivenAwards = new Dictionary<string, HashSet<string>>();

            while (true)
            {
                List<string> input = new List<string>();
                input = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                                  .Select(x => x.Trim())
                                  .ToList();

                if (input[0] == "dawn")
                {
                    break;
                }

                // Since we are interested only in the awards given, we can safely ignore inputs with no awards or songs mentioned
                if (input.Count < 3)
                {
                    continue;
                }

                string currentPerformer = input[0];
                string currentSong = input[1];
                string currentAward = input[2];

                // If the perfomer or the song are not contained in the list of participants or songs, the input is of no interest to us.
                if (!participants.Contains(currentPerformer))
                {
                    continue;
                }

                if (!songs.Contains(currentSong))
                {
                    continue;
                }

                if (!properlyGivenAwards.ContainsKey(currentPerformer))
                {
                    properlyGivenAwards[currentPerformer] = new HashSet<string>();
                }

                properlyGivenAwards[currentPerformer].Add(currentAward);
            }

            if (properlyGivenAwards.Keys.Count == 0)
            {
                Console.WriteLine("No awards");
            }
            else
            {
                foreach (var kvp in properlyGivenAwards.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{kvp.Key}: {kvp.Value.Count} awards");
                    foreach (string award in kvp.Value.OrderBy(x => x))
                    {
                        Console.WriteLine($"--{award}");
                    }
                }
            }
        }
    }
}