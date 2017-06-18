using System;
using System.Collections.Generic;

public class ImmuneSystem
{
    public static void Main()
    {
        int initialHealth = int.Parse(Console.ReadLine());
        int currentHealth = initialHealth;
        HashSet<string> defeatedViruses = new HashSet<string>();
        string virusName = string.Empty;

        while ((virusName = Console.ReadLine()) != "end")
        {
            int virusStrength = 0;

            for (int i = 0; i < virusName.Length; i++)
            {
                virusStrength += virusName[i];
            }

            virusStrength /= 3;

            int virusDefeatSeconds = virusStrength * virusName.Length;

            if (defeatedViruses.Contains(virusName))
            {
                virusDefeatSeconds /= 3;
            }

            int defeatMins = virusDefeatSeconds / 60;
            int defeatSecs = virusDefeatSeconds % 60;

            Console.WriteLine($"Virus {virusName}: {virusStrength} => {virusDefeatSeconds} seconds");

            if (currentHealth <= virusDefeatSeconds)
            {
                Console.WriteLine($"Immune System Defeated.");
                return;
            }

            Console.WriteLine($"{virusName} defeated in {defeatMins}m {defeatSecs}s.");
            currentHealth -= virusDefeatSeconds;

            Console.WriteLine($"Remaining health: {currentHealth}");
            currentHealth = Math.Min(initialHealth, (int)(currentHealth * 1.2));
            defeatedViruses.Add(virusName);
        }

        if (currentHealth > 0)
        {
            Console.WriteLine($"Final Health: {currentHealth}");
        }
    }
}