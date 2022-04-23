namespace Eclipse.Core
{
    public abstract class ShipPart
    {
        public ShipPart(string name, int initiative, int energyConsumption)
        {
            Name = name;
            Initiative = initiative;
            EnergyConsumption = energyConsumption;
        }

        public abstract ShipPartType Type { get; }

        public string Name { get; }
        public int Initiative { get; }

        public int EnergyConsumption { get; }
    }

}