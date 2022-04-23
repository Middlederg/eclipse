namespace Eclipse.Core
{
    public class EnergySource : ShipPart
    {
        public EnergySource(string name, int initiative, int energyConsumption, int power) : base(name, initiative, energyConsumption)
        {
            Power = power;
        }

        public override ShipPartType Type => ShipPartType.EnergySource;

        public int Power { get; }
    }
}