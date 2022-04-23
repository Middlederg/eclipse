namespace Eclipse.Core
{
    public class Dice
    {
        public static Dice Yellow => new Dice(DiceColor.Yellow);

        public static Dice Orange => new Dice(DiceColor.Orange);

        public static Dice Blue => new Dice(DiceColor.Blue);

        public static Dice Red => new Dice(DiceColor.Red);

        public DiceColor Color { get; }
        public int Damage => (int)Color;

        public Dice(DiceColor color)
        {
            Color = color;
        }

        public DiceResult Roll(int attackerComputers, int defenderShield, IDiceRoller diceRoller)
        {
            int result = diceRoller.Roll();
            if (result <= 1)
            {
                return DiceResult.Miss();
            }
            if (result >= 6)
            {
                return DiceResult.Hit(this);
            }
            if (result + attackerComputers - defenderShield >= 6)
            {
                return DiceResult.Hit(this);
            }

            return DiceResult.Miss();
        }
    }

}