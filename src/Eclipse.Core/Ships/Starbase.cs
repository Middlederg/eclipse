namespace Eclipse.Core
{
    public class Starbase : Ship
    {
        public Starbase(BaseStats baseStats, int slots = 5, int cost = 4, params ShipPart[] shipParts) : base(baseStats, slots, cost, shipParts) {  }

        public override string Name => "Starbase";

        public override string Description => "A heavily static armored ship";
    }
}