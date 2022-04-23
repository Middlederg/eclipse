namespace Eclipse.Core
{
    public class Hull : ShipPart
    {
        public Hull(string name, int initiative, int energyConsumption, int strength) : base(name, initiative, energyConsumption)
        {
            Strength = strength;
            Repair();
        }

        public override ShipPartType Type => ShipPartType.Hull;

        public int Strength { get; }

        public int CurrentPoints { get; private set;}
        public void Damage() => CurrentPoints--;
        public bool IsDestroyed => Strength <= 0;

        public void Repair() => CurrentPoints = Strength;
    }

}