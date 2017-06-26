namespace Jarvis
{
    public class Torso
    {
        internal int EnergyConsumption { get; set; }
        internal double ProcessorSize { get; set; }
        internal string HousingMaterial { get; set; }

        public Torso(int energy, double processor, string housing)
        {
            EnergyConsumption = energy;
            ProcessorSize = processor;
            HousingMaterial = housing;
        }
    }
}