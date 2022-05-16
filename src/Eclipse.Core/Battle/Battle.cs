namespace Eclipse.Core
{
    public class Battle
    {
        public IEnumerable<BattleGroup> Groups => AllOrderedShips.Where(x => x.OwnerType == OwnerType.Player);

        public IEnumerable<BattleGroup> EnemyGroups => AllOrderedShips.Where(x => x.OwnerType == OwnerType.Enemy);

        public IEnumerable<BattleGroup> AllOrderedShips { get; }

        public int CurrentTurn { get; private set; } = 0;
        public bool IsEnemiesTurn => AllOrderedShips.ElementAt(CurrentTurn).OwnerType == OwnerType.Enemy;
        public BattleGroup ActiveGroup => AllOrderedShips.ElementAt(CurrentTurn);
        public bool IsEnded => Groups.All(x => !x.HasActiveShip()) || EnemyGroups.All(x => !x.HasActiveShip());
        public OwnerType? GetWinner
        {
            get
            {
                if (!IsEnded)
                {
                    return null;
                }

                return Groups.Any(x => !x.HasActiveShip()) ? OwnerType.Player : OwnerType.Enemy;
            }
        }

        public void NextTurn()
        {
            SetNextTurn();

            bool thereIsActiveShip = ActiveGroup.HasActiveShip();
            while(!thereIsActiveShip)
            {
                SetNextTurn();
                thereIsActiveShip = ActiveGroup.HasActiveShip();
            }
        }
        private void SetNextTurn() => CurrentTurn = CurrentTurn + 1 < AllOrderedShips.Count() ? CurrentTurn + 1 : 0;

        public Battle(IEnumerable<Ship> ships, IEnumerable<Ship> enemyShips)
        {
            var groups = ships.GroupBy(x => x.Type).Select((x, index) => BattleGroup.Create(index, x));
            var enemyGroups = enemyShips.GroupBy(x => x.Type).Select((x, index) => BattleGroup.CreateEnemy(index, x));
            AllOrderedShips = groups.Concat(enemyGroups)
               .OrderBy(x => x.Ships.First().Initiative)
               .ToList();
        }

        public Ship GetEnemyFirstActiveShip()
        {
            if (!EnemyGroups.Any(group => group.HasActiveShip()))
            {
                return null;
            }

            return EnemyGroups.First(group => group.HasActiveShip()).Ships.First();
        }

        public Ship GetPlayersWeakestShip()
        {
            if (!Groups.Any(group => group.HasActiveShip()))
            {
                return null;
            }

            var candidates = Groups.Select(group => group.WeakestShip).Where(x => x is not null);
            return candidates.OrderBy(x => x.CurrentStrength).FirstOrDefault();
        }
    }
}