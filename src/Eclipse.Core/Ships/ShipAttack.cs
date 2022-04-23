namespace Eclipse.Core
{
    public class ShipAttack
    {
        private readonly IDiceRoller diceRoller;

        public ShipAttack(IDiceRoller diceRoller)
        {
            this.diceRoller = diceRoller;
        }

        public IEnumerable<DiceResult> MakeAttack(Ship attacker, Ship defender)
        {
            var diceResults = attacker.ShootCannons(defender.Shields, diceRoller);
            defender.Damage(diceResults);
            return diceResults;
        }
    }
}