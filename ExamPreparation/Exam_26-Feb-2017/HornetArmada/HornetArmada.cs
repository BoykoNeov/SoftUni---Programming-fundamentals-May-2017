using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// The Hornet Overlord Nostalgia, who is famed for his absolute discipline and strict orders, owns the most sorted army in the Hornet history. Help Nostalgia “computerize” the process of sorting out his army.
/// You will be given N – an integer.
/// On the next N lines you will be given input containing information about soldiers in the following format:
/// { lastActivity} = {legionName} -> {soldierType}:{soldierCount}
/// The last activity is an integer.The legion name and soldier type, will both be strings. The soldier count will be an integer.You must store every legion with its activity, and every soldier type with its count, in its legion.
/// If a given legion already exists, you must add the new soldier type, with its count.If the soldier type exists ALSO, you should just add the soldier count.
/// IN BOTH cases, stated above, you should update the last activity, with the newly entered one, ONLY if the entered one is GREATER than the previous one.
/// After you’ve read all N input lines, you will receive a line in one of the following formats:
/// { activity}\{soldierType}
/// {soldierType}
/// In the first case, you must print all legions, and the count of soldiers they have from the given soldier type, who’s last activity is LOWER than the given activity.The legions must be printed in descending order by soldier count.
/// In the second case, you must print all legions which have the given soldier type, with last activity, and legion name.The legions must be printed in descending order of their activity.
/// Input
/// On the first line you will receive N – the integer.
/// On the next N lines you will receive data about soldiers and legions.
/// On the last line you will receive one of the two commands, which will determine the output.
/// Output
/// If you are given the last activity and soldier type on the last command, you must print the legions in this format:
/// { legionName} -> {soldierCount}
/// If you are given only the soldier type on the last command, you must print the legions in this format:
/// {lastActivity} : {legionName}
/// Constrains
/// The first integer – N, will be in range[0; 10,000].
/// The legion names and soldier types may consist of any ASCII character, except “=”, “-”, “>”, “:”, “ ”(space).
/// The soldier count and last activity will be integers in range[0; 1,000,000,000]. 
/// All input data will be exactly as stated above.There will be NO invalid input lines.
/// Data which has NO specified order must be sorted in order of input.
/// </summary>
public class HornetArmada
{
    public static void Main()
    {
        Dictionary<string, Legion> legionsByName = new Dictionary<string, Legion>();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] inputs = Console.ReadLine().Split(new char[] { '=', '-', '>', ':', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int activity = int.Parse(inputs[0]);
            string legionName = inputs[1];
            string soldierType = inputs[2];
            long soldierCount = long.Parse(inputs[3]);

            Legion currentLegion = new Legion();

            if (!legionsByName.ContainsKey(legionName))
            {
                legionsByName.Add(legionName, currentLegion);
            }
            else
            {
                currentLegion = legionsByName[legionName];
            }

            if (!currentLegion.Soldiers.ContainsKey(soldierType))
            {
                currentLegion.Soldiers.Add(soldierType, soldierCount);
            }
            else
            {
                currentLegion.Soldiers[soldierType] += soldierCount;
            }

            if (currentLegion.LastActivity < activity)
            {
                currentLegion.LastActivity = activity;
            }
        }

        string[] outputParams = Console.ReadLine().Split(new char[] { '\\' });

        if (outputParams.Length > 1)
        {
            int activityThreshold = int.Parse(outputParams[0]);
            string outputSoldierType = outputParams[1];

            Dictionary<string, long> soldiersByCount = new Dictionary<string, long>();

            foreach (KeyValuePair<string, Legion> legion in legionsByName.Where(x => x.Value.LastActivity < activityThreshold))
            {
                foreach (var kvp in legion.Value.Soldiers)
                {
                    if (kvp.Key == outputSoldierType)
                    {
                        soldiersByCount.Add(legion.Key, kvp.Value);
                    }
                }
            }

            foreach (var soldiers in soldiersByCount.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{soldiers.Key} -> {soldiers.Value}");
            }
        }
        else
        {
            string soldierType = outputParams[0];

            foreach (var legions in legionsByName.Where(x => x.Value.Soldiers.ContainsKey(soldierType)).OrderByDescending(x => x.Value.LastActivity))
            {
                Console.WriteLine($"{legions.Value.LastActivity} : {legions.Key}");
            }
        }
    }
}

//Using the same file, because of Judge restrictions
/// <summary>
/// Class for holding legion information
/// </summary>
public class Legion
{
    private int lastActivity;

    private Dictionary<string, long> soldiers;

    public Dictionary<string, long> Soldiers { get => soldiers; set => soldiers = value; }
    public int LastActivity { get => lastActivity; set => lastActivity = value; }

    public Legion()
    {
        Soldiers = new Dictionary<string, long>();
        LastActivity = int.MinValue;
    }
}