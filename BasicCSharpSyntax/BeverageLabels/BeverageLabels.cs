/// <summary>
/// Write a program, which reads a food product name, volume, energy content per 100ml and sugar content per 100ml. Calculate the energy and sugar content for the given volume and print them on the console in the following format:
/// Name – as per the input
/// Volume – integer, suffixed by “ml” (e.g. “220ml”)
/// Energy content – integer, suffixed by “kcal” (e.g. “500kcal”)
/// Sugar content – integer, suffixed by “g” (e.g. “30g”) 
/// </summary>
namespace BeverageLabels
{
    using System;

    public class BeverageLabels
    {
        public static void Main()
        {
            string beverageName = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            double energyPerOneMl = int.Parse(Console.ReadLine()) / 100d;
            double sugarPerOneMl = int.Parse(Console.ReadLine()) / 100d;

            Console.WriteLine($"{volume}ml {beverageName}:");
            double totalEnergy = (energyPerOneMl * volume);
            double totalSugar = (sugarPerOneMl * volume);
            Console.WriteLine($"{totalEnergy}kcal, {totalSugar}g sugars");
        }
    }
}