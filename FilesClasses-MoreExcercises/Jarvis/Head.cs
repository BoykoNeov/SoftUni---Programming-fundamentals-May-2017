namespace Jarvis
{
    public class Head
    {
        internal int EnergyConsumption { get; set; }
        internal int IQ { get; set; }
        internal string SkinMaterial { get; set; }

        public Head(int energy, int iq, string skin)
        {
            EnergyConsumption = energy;
            IQ = iq;
            SkinMaterial = skin;
        }
    }
}