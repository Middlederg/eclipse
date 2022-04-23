namespace Eclipse.Core
{
    public class Computer : ShipPart
    {
        public Computer(string name, int initiative, int energyConsumption, int attack) : base(name, initiative, energyConsumption)
        {
            Attack = attack;
        }

        public override ShipPartType Type => ShipPartType.Computer;

        public int Attack { get; }
    }
}