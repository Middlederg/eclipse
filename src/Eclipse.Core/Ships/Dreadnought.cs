namespace Eclipse.Core
{
    public class Dreadnought : Ship
    {
        public Dreadnought(BaseStats baseStats, int slots = 8, int cost = 10, params ShipPart[] shipParts) : base(baseStats, slots, cost, shipParts) {  }

        public override string Name => "Dreadnought";

        public override string Description => "A large, heavy ship with a large crew.";

        public override ShipType Type => ShipType.Dreadnought;
    }
}