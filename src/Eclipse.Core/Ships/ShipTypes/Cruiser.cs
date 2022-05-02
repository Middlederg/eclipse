namespace Eclipse.Core
{
    public class Cruiser : Ship
    {
        public Cruiser(BaseStats baseStats, SpecieColor color, int slots = 6, int cost = 5, params ShipPart[] shipParts) : base(baseStats, color, slots, cost, shipParts) {  }

        public override string Name => "Cruiser";

        public override string Description => "A medium sized ship with a medium crew.";

        public override ShipType Type => ShipType.Cruiser;
    }
}