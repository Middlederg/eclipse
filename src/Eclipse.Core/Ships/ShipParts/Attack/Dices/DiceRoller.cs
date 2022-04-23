namespace Eclipse.Core
{
    public class DiceRoller : IDiceRoller
    {
        public int Roll() => new Random().Next(1, 7);
    }

}