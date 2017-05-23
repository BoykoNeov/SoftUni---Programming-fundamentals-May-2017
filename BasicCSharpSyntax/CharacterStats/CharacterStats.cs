/// <summary>
/// Write a program, which displays information about a video game character. 
/// You will receive their name, current health, maximum health, current energy and maximum energy on separate lines.
/// The current values will always be valid (equal or lower than their respective max values).
/// </summary>
namespace CharacterStats
{
    using System;

    class CharacterStats
    {
        static void Main()
        {
            string characterName = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            string outputHealth = "|" + new string('|', currentHealth) + new string('.', (maxHealth - currentHealth)) + "|";
            string outputEnergy = "|" + new string('|', currentEnergy) + new string('.', (maxEnergy - currentEnergy)) + "|";

            Console.WriteLine($"Name: {characterName}");
            Console.WriteLine($"Health: {outputHealth}");
            Console.WriteLine($"Energy: {outputEnergy}");
        }
    }
}