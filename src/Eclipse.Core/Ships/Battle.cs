namespace Eclipse.Core
{
    public class Battle
    {
        public IEnumerable<BattleGroup> Groups { get; }

        public IEnumerable<BattleGroup> EnemyGroups { get; }

        public IEnumerable<BattleGroup> Order => Groups.Concat(EnemyGroups)
            .OrderBy(x => x.Ships.First().Initiative)
            .ToList();

        public int CurrentTurn { get; private set; } = 0;
        public bool IsEnemiesTurn => Order.Any() && Order.ElementAt(CurrentTurn).OwnerType == OwnerType.Enemy;
        public BattleGroup ActiveGroup => Order.Any() ? Order.ElementAt(CurrentTurn) : null;

        public void NextTurn()
        {
            CurrentTurn = CurrentTurn + 1 < Order.Count() ? CurrentTurn + 1 : 0;

            while(!ActiveGroup.HasActiveShip())
            {
                CurrentTurn++;
            }
        }


        public Battle(IEnumerable<Ship> ships, IEnumerable<Ship> enemyShips)
        {
            Groups = ships.GroupBy(x => x.Type).Select((x, index) => BattleGroup.Create(index, x));
            EnemyGroups = enemyShips.GroupBy(x => x.Type).Select((x, index) => BattleGroup.CreateEnemy(index, x));
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