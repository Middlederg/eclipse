namespace Eclipse.Core
{
    public class Battle
    {
        public IEnumerable<Ship> Ships { get; }

        public IEnumerable<Ship> EnemyShips { get; }

        public Battle(IEnumerable<Ship> ships, IEnumerable<Ship> enemyShips)
        {
            Ships = ships;
            EnemyShips = enemyShips;
        }

        public Ship GetEnemyShip()
        {
            return EnemyShips.FirstOrDefault(x => !x.IsDestroyed);
        }
    }
}