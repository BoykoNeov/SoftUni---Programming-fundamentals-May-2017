namespace CharityMarathon
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CharityMarathon
    {
        public static void Main()
        {
            int days = int.Parse(Console.ReadLine());
            int runners = int.Parse(Console.ReadLine());
            int laps = int.Parse(Console.ReadLine());
            decimal trackLength = decimal.Parse(Console.ReadLine()) / 1000;
            int trackCapacity = int.Parse(Console.ReadLine());
            decimal moneyPerKilometer = decimal.Parse(Console.ReadLine());

            decimal participatingRunners = 0;

            participatingRunners = Math.Min((trackCapacity * days), runners);

            decimal totalKMrun = trackLength * participatingRunners * laps;

            decimal totalMoneyRaised = 0;
            totalMoneyRaised = totalKMrun * moneyPerKilometer;
            Console.WriteLine($"Money raised: {totalMoneyRaised:f2}");
        }
    }
}