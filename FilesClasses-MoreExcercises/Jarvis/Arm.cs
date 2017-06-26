namespace Jarvis
{
    public class Arm
    {
        internal int EnergyConsumption { get; set; }
        internal int Reach { get; set; }
        internal int FingersCount { get; set; }

        public Arm(int energy, int reach, int fingerCount)
        {
            EnergyConsumption = energy;
            Reach = reach;
            FingersCount = fingerCount;
        }
    }
}