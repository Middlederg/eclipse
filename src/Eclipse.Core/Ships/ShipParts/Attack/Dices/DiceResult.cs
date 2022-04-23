namespace Eclipse.Core
{
    public class DiceResult
    {
        private readonly Dice dice;

        public int Damage => dice?.Damage ?? 0;
        public bool Success { get; }
        public DiceColor Color => dice.Color;

        public static DiceResult Hit(Dice dice) => new DiceResult(dice, true);
        public static DiceResult Miss(Dice dice) => new DiceResult(dice, false);
        private DiceResult(Dice dice, bool success)
        {
            this.dice = dice;
            Success = success;
        }
    }

}