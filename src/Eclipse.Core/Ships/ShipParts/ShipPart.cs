namespace Eclipse.Core
{
    public abstract class ShipPart
    {
        public static ShipPart Empty => new EmptyShipPart();
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

    public class EmptyShipPart : ShipPart
    {
        public EmptyShipPart() : base("Empty", 0, 0)
        {
        }

        public override ShipPartType Type => ShipPartType.None;
    }

}