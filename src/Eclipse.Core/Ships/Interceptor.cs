namespace Eclipse.Core
{
    public class Interceptor : Ship
    {
        public Interceptor(BaseStats baseStats, int slots = 4, int cost = 3, params ShipPart[] shipParts) : base(baseStats, slots, cost, shipParts) {  }

        public override string Name => "Interceptor";

        public override string Description => "A small, agile ship with a small crew.";
    }
}