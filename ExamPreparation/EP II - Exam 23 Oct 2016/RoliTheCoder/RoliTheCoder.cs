/// <summary>
/// Roli is really busy with the recently started JS Core and DB Fundamentals modules at SoftUni. She is used to going out with friends on a various events. However, when the times comes, you need to tell her to start coding.
/// Roli is the organizer of those events, so she needs to keep track of the unique participants for each event. She saves the events by 'ID', which is the unique code for each event. For each ID, she keeps the event name and the participants for it.
/// She receives request in the following format:
/// { id} #{eventName} @{participant1} @{participant2} … @{participantN}
/// If she is given event in an invalid format (such as without a hashtag), she ignores that line of input. If she is given ID that already exists she needs to check if the eventName is the same. If it is, she adds the participants from the request to the other registered participants. If the event id exists but the name doesn’t, it is invalid and you need to ignore it.
/// After you receive "Time for Code", you need to print the results. All events must be sorted by participant count in descending order and then by alphabetical order. For each event, the participants must be sorted in alphabetical order.
/// Input / Constrains
/// Unil you receive “Time for Code” you will get lines of input in which everything is separated by one or more blank spaces
/// Until you receive "Time for Code", you will be receiving events in the following format:
/// { id} #{eventName} @{participant1} @{participant2} … @{participantN}
/// Output
/// All events must be sorted in descending order by participant count and then by alphabetical order. For each event you need to print:
/// { eventName} – { participantCount}
/// On the next lines you need to print all participants. All participants for an event must be sorted alphabetically.
/// </summary>
namespace RoliTheCoder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RoliTheCoder
    {
        public static void Main()
        {
            Dictionary<string, string> IdEvents = new Dictionary<string, string>();
            Dictionary<string, HashSet<string>> eventsParticipants = new Dictionary<string, HashSet<string>>();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Time for Code")
            {
                string[] inputs = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string id = inputs[0];
                string eventName = inputs[1];

                // ignore this input line if it is invalid
                if (eventName[0] != '#')
                {
                    continue;
                }

                //Remove the hashtag from event name
                eventName = eventName.Substring(1);

                // if the name differs from the already existing , ignore that input line
                if (!IdEvents.ContainsKey(id))
                {
                    IdEvents.Add(id, eventName);
                }
                else if (IdEvents[id] != eventName)
                {
                    continue;
                }

                if (!eventsParticipants.ContainsKey(eventName))
                {
                    eventsParticipants.Add(eventName, new HashSet<string>());
                }

                for (int i = 2; i < inputs.Length; i++)
                {
                    string participant = inputs[i];
                    eventsParticipants[eventName].Add(participant);
                }
            }

            foreach (var participantsKVP in eventsParticipants
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{participantsKVP.Key} - {participantsKVP.Value.Count}");
                foreach (string participant in participantsKVP.Value.OrderBy(x => x))
                {
                    Console.WriteLine(participant);
                }
            }
        }
    }
}