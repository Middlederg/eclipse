namespace Eclipse.Core
{
    public class BattleGroup
    {
        public int Index { get; }
        public IEnumerable<Ship> Ships { get; }
        public OwnerType OwnerType { get; }

        public static BattleGroup Create(int index, IEnumerable<Ship> ships) => new(index, ships, OwnerType.Player);
        public static BattleGroup CreateEnemy(int index, IEnumerable<Ship> ships) => new(index, ships, OwnerType.Enemy);
        private BattleGroup(int index, IEnumerable<Ship> ships, OwnerType ownerType)
        {
            Index = index;
            Ships = ships;
            OwnerType = ownerType;
        }

        public bool HasActiveShip() => Ships.Any(x => !x.IsDestroyed);

        public Ship WeakestShip => Ships.OrderBy(x => x.CurrentStrength).FirstOrDefault();
    }
}