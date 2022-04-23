namespace Eclipse.Core
{
    public class Drive : ShipPart
    {
        public Drive(string name, int initiative, int energyConsumption, int speed) : base(name, initiative, energyConsumption)
        {
            Speed = speed;
        }

        public override ShipPartType Type => ShipPartType.Drive;

        public int Speed { get; }
    }
}