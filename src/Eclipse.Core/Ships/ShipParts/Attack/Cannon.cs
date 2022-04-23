namespace Eclipse.Core
{
    public class Cannon : ShipPart, IShootable
    {
        private readonly Dice[] dices;

        public Cannon(string name, int initiative, int energyConsumption, params Dice[] dices) : base(name, initiative, energyConsumption)
        {
            this.dices = dices;
        }

        public override ShipPartType Type => ShipPartType.Cannon;

        public IEnumerable<DiceResult> Shoot(int attackerComputers, int defenderShield, IDiceRoller diceRoller)
        {
            foreach (var dice in dices)
            {
                yield return dice.Roll(attackerComputers, defenderShield, diceRoller);
            }
        }
    }
}