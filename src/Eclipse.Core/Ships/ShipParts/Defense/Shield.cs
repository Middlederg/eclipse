namespace Eclipse.Core
{
    public class Shield : ShipPart
    {
        public Shield(string name, int initiative, int energyConsumption, int defense) : base(name, initiative, energyConsumption)
        {
            Defense = defense;
        }

        public override ShipPartType Type => ShipPartType.Shield;

        public int Defense { get; }
    }
}