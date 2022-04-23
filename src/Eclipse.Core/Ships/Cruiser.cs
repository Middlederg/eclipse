namespace Eclipse.Core
{
    public class Cruiser : Ship
    {
        public Cruiser(BaseStats baseStats, int slots = 6, int cost = 5, params ShipPart[] shipParts) : base(baseStats, slots, cost, shipParts) {  }

        public override string Name => "Cruiser";

        public override string Description => "A medium sized ship with a medium crew.";
    }
}