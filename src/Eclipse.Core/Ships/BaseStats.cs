namespace Eclipse.Core
{
    public class BaseStats
    {
        public int Movement { get; }
        public int Initiative { get; }
        public int Computers { get; }
        public int Defense { get; }
        public int Power { get; }

        public BaseStats(int movement, int initiative, int computers, int shields, int power)
        {
            Movement = movement;
            Initiative = initiative;
            Computers = computers;
            Defense = shields;
            Power = power;
        }
    }
}