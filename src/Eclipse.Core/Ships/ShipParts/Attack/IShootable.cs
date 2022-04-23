namespace Eclipse.Core
{
    public interface IShootable
    {
         IEnumerable<DiceResult> Shoot(int attackerComputers, int defenderShield, IDiceRoller diceRoller);
    }
}