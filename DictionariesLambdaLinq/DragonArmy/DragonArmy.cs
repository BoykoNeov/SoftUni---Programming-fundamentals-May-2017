// Task Dragon Army
// Check the file ../06. Programming-Fundamentals-Dictionaries-Lambda-LINQ-Exercises for task description

using System;
using System.Collections.Generic;
using System.Linq;

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