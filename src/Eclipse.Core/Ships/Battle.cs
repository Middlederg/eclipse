namespace Eclipse.Core
{
    public class Battle
    {
        private readonly IEnumerable<Ship> ships;

        private readonly IEnumerable<Ship> enemyShips;

        public Battle(IEnumerable<Ship> ships, IEnumerable<Ship> enemyShips)
        {
            this.ships = ships;
            this.enemyShips = enemyShips;
        }
    }
}