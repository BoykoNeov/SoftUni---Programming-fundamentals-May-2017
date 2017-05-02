using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Task "Legendary Farming"
/// The possible items are:
/// - Shadowmourne – requires 250 Shards;
/// - Valanyr – requires 250 Fragments;
/// - Dragonwrath – requires 250 Motes;
/// Shards, Fragments and Motes are the key materials, all else is junk.You will be given lines of input, such as 
/// 2 motes 3 ores 15 stones.Keep track of the key materials - the first that reaches the 250 mark wins the race.
/// At that point, print the corresponding legendary obtained.Then, print the remaining shards, fragments, motes,
/// ordered by quantity in descending order, then by name in ascending order, each on a new line.Finally, print
/// the collected junk items, in alphabetical order.
/// </summary>
public class LegendaryFarming
{
    public static void Main()
    {
        var suppliesQuantity = new Dictionary<string, int>();
        string legendaryItem = string.Empty;
        bool legendaryFound = false;
        suppliesQuantity.Add("shards", 0);
        suppliesQuantity.Add("fragments", 0);
        suppliesQuantity.Add("motes", 0);

        while (legendaryFound == false)
        {
            var input = Console.ReadLine()
                .ToLower()
                .Split(new char[] { ' ' }, StringSplitOptions
                .RemoveEmptyEntries)
                .ToList();

            for (int i = 0; i < input.Count; i = i + 2)
            {
                if (!suppliesQuantity.ContainsKey(input[i + 1]))
                {
                    suppliesQuantity.Add(input[i + 1], int.Parse(input[i]));
                }
                else
                {
                    suppliesQuantity[input[i + 1]] += int.Parse(input[i]);
                }

                if (suppliesQuantity["shards"] >= 250)
                {
                    suppliesQuantity["shards"] -= 250;
                    legendaryItem = "Shadowmourne";
                    legendaryFound = true;
                    break;
                }

                if (suppliesQuantity["fragments"] >= 250)
                {
                    suppliesQuantity["fragments"] -= 250;
                    legendaryItem = "Valanyr";
                    legendaryFound = true;
                    break;
                }

                if (suppliesQuantity["motes"] >= 250)
                {
                    suppliesQuantity["motes"] -= 250;
                    legendaryItem = "Dragonwrath";
                    legendaryFound = true;
                    break;
                }
            }
        }

        Console.WriteLine($"{legendaryItem} obtained!");

        var keyMaterials = new Dictionary<string, int>();

        for (int i = 0; i < 3; i++)
        {
            string material = string.Empty;

            switch (i)
            {
                case 0:
                    material = "motes";
                    break;
                case 1:
                    material = "fragments";
                    break;
                case 2:
                    material = "shards";
                    break;
            }

            if (suppliesQuantity.ContainsKey(material))
            {
                keyMaterials.Add(material, suppliesQuantity[material]);
                suppliesQuantity.Remove(material);
            }
        }

        foreach (var kvpKeyMaterials in keyMaterials.OrderByDescending(x => x.Value)
                    .ThenBy(y => y.Key))
        {
            Console.WriteLine($"{kvpKeyMaterials.Key}: {kvpKeyMaterials.Value}");
        }

        foreach (var kvpSuppliesQuantity in suppliesQuantity.OrderBy(x => x.Key))
        {
            Console.WriteLine($"{kvpSuppliesQuantity.Key}: {kvpSuppliesQuantity.Value}");
        }
    }
}