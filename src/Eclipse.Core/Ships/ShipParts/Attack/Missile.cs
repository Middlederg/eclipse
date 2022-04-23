namespace Eclipse.Core
{
    public class Missile : ShipPart, IShootable
    {
        private readonly Dice[] dices;

        public Missile(string name, int initiative, int energyConsumption, params Dice[] dices) : base(name, initiative, energyConsumption)
        {
            this.dices = dices;
        }

        public override ShipPartType Type => ShipPartType.Missile;

        public IEnumerable<DiceResult> Shoot(int attackerComputers, int defenderShield, IDiceRoller diceRoller)
        {
            foreach (var dice in dices)
            {
                yield return dice.Roll(attackerComputers, defenderShield, diceRoller);
            }
        }
    }

}