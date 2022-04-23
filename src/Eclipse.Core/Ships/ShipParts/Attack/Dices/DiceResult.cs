namespace Eclipse.Core
{
    public class DiceResult
    {
        public int Damage { get; }
        public bool Success { get; }

        public static DiceResult Hit(Dice dice) => new DiceResult(dice, true);
        public static DiceResult Miss() => new DiceResult(null, false);
        private DiceResult(Dice dice, bool success)
        {
            Damage = dice?.Damage ?? 0;
            Success = success;
        }
    }

}