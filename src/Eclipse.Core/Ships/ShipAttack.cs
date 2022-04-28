namespace Eclipse.Core
{
    public class ShipAttack
    {
        private readonly IDiceRoller diceRoller;

        public ShipAttack(IDiceRoller diceRoller)
        {
            this.diceRoller = diceRoller;
        }

        public IEnumerable<DiceResult> MakeAttack(BattleGroup attacker, Func<Ship> shipSelector)
        {
            var target = shipSelector();
            if (target is not null)
            {
                foreach (var attackerShip in attacker.Ships)
                {
                    var diceResults = attackerShip.ShootCannons(target.Shields, diceRoller);
                    target.SufferDamage(diceResults);

                    foreach (var diceResult in diceResults)
                    {
                        yield return diceResult;
                    }
                }
            }
        }
    }
}