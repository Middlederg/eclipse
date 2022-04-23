namespace Eclipse.Core
{
    public class ShipPartCollection
    {
        public ShipPartCollection(IEnumerable<ShipPart> shipParts)
        {
            ShipParts = shipParts.ToList();
        }

        public List<ShipPart> ShipParts { get; }

        public int Initiative => ShipParts.Sum(x => x.Initiative);

        public int Power => EnergySources.Sum(x => x.Power);

        public int EnergyConsumption => ShipParts.Sum(x => x.EnergyConsumption);

        public IEnumerable<Cannon> Cannons => ShipParts.Where(x => x.Type == ShipPartType.Cannon).Cast<Cannon>();

        public IEnumerable<Missile> Missils => ShipParts.Where(x => x.Type == ShipPartType.Missile).Cast<Missile>();

        public IEnumerable<Hull> Hulls => ShipParts.Where(x => x.Type == ShipPartType.Hull).Cast<Hull>();

        public IEnumerable<Computer> Computers => ShipParts.Where(x => x.Type == ShipPartType.Computer).Cast<Computer>();

        public IEnumerable<Shield> Shields => ShipParts.Where(x => x.Type == ShipPartType.Shield).Cast<Shield>();

        public IEnumerable<EnergySource> EnergySources => ShipParts.Where(x => x.Type == ShipPartType.EnergySource).Cast<EnergySource>();

        public bool Has(ShipPartType type) => ShipParts.Any(x => x.Type == type);

        public void InsertPart(ShipPart shipPart, int position)
        {
            ShipParts.RemoveAt(position);
            ShipParts.Insert(position, shipPart);
        }

    }
}