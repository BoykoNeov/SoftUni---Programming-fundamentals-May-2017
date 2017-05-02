using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Task "Dragon Army"
/// You need to categorize dragons by their type. For each dragon, identified by name, keep information about his stats.
/// Type is preserved as in the order of input, but dragons are sorted alphabetically by name. For each type,
/// you should also print the average damage, health and armor of the dragons. For each dragon, print his own stats. 
/// There may be missing stats in the input, though. If a stat is missing you
/// should assign it default values.Default values are as follows: health 250, damage 45, 
/// and armor 10. Missing stat will be marked by null.
/// The input is in the following format {type} {name} {damage} {health} {armor}. Any of the integers
/// may be assigned null value.See the examples below for better understanding of your task.
/// If the same dragon is added a second time, the new stats should overwrite the previous ones.
/// Two dragons are considered equal if they match by both name and type.
/// - On the first line, you are given number N -> the number of dragons to follow
/// - On the next N lines you are given input in the above described format. There will be single
/// space separating each element.
/// Output
/// - Print the aggregated data on the console
/// - For each type, print average stats of its dragons in format { Type}::({damage}/{health}/{armor})
/// - Damage, health and armor should be rounded to two digits after the decimal separator
/// - For each dragon, print its stats in format -{Name} -> damage: {damage}, health: {health}, armor: {armor}
/// #### Constraints
/// - N is in range[1…100]
/// - The dragon type and name are one word only, starting with capital letter.
/// - Damage health and armor are integers in range[0 … 100000] or null
/// </summary>
public class DragonArmy
{
    public static void Main()
    {
        var dragons = new Dictionary<string, Dictionary<string, int[]>>();
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var inputs = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions
                .RemoveEmptyEntries)
                .ToArray();

            string dragonColor = inputs[0];
            string dragonName = inputs[1];
            int dragonDamage;
            int dragonHealth;
            int dragonArmour;

            if (!int.TryParse(inputs[2], out dragonDamage))
            {
                dragonDamage = 45;
            }

           if (!int.TryParse(inputs[3], out dragonHealth))
            {
                dragonHealth = 250;
            }

            if (!int.TryParse(inputs[4], out dragonArmour))
            {
                dragonArmour = 10;
            }

            if (!dragons.ContainsKey(inputs[0]))
            {
                dragons[inputs[0]] = new Dictionary<string, int[]>();
            }

            if (!dragons[inputs[0]].ContainsKey(inputs[1]))
            {
                dragons[inputs[0]].Add(inputs[1], new int[3]);
            }

            dragons[inputs[0]][inputs[1]][0] = dragonDamage;
            dragons[inputs[0]][inputs[1]][1] = dragonHealth;
            dragons[inputs[0]][inputs[1]][2] = dragonArmour;
        }

        foreach (var kvpDragonsByColor in dragons)
        {
            double meanDamage = 0;
            double meanHealth = 0;
            double meanArmour = 0;
            double totalDamage = 0;
            double totalHealth = 0;
            double totalArmour = 0;

            string individualDragonOutput = string.Empty;

            foreach (var kvpDragonsByName in dragons[kvpDragonsByColor.Key].OrderBy(x => x.Key))
            {
                totalDamage += kvpDragonsByName.Value[0];
                totalHealth += kvpDragonsByName.Value[1];
                totalArmour += kvpDragonsByName.Value[2];
                individualDragonOutput += string.Format($"-{kvpDragonsByName.Key} -> damage: {kvpDragonsByName.Value[0]}, health: {kvpDragonsByName.Value[1]}, armor: {kvpDragonsByName.Value[2]}{Environment.NewLine}");
            }

            meanDamage = totalDamage / (kvpDragonsByColor.Value.Count);
            meanHealth = totalHealth / (kvpDragonsByColor.Value.Count);
            meanArmour = totalArmour / (kvpDragonsByColor.Value.Count);
            Console.WriteLine($"{kvpDragonsByColor.Key}::({meanDamage:f2}/{meanHealth:f2}/{meanArmour:f2})");
            Console.Write(individualDragonOutput);
        }
    }
}