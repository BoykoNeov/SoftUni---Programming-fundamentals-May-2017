namespace Jarvis
{
    public class Leg
    {
        internal int EnergyConsumption { get; set; }
        internal int Strength { get; set; }
        internal int Speed { get; set; }

        public Leg(int energy, int strength, int speed)
        {
            EnergyConsumption = energy;
            Strength = strength;
            Speed = speed;
        }
    }
}