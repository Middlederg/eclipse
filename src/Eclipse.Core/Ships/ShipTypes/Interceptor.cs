namespace Eclipse.Core
{
    public class Interceptor : Ship
    {
        public Interceptor(BaseStats baseStats, SpecieColor color, int slots = 4, int cost = 3, params ShipPart[] shipParts) : base(baseStats, color, slots, cost, shipParts) { }

        public override string Name => "Interceptor";

        public override string Description => "A small, agile ship with a small crew.";

        public override ShipType Type => ShipType.Interceptor;
    }
}