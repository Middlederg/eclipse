namespace Eclipse.Core
{
    public static class ShieldExtensions
    {
        public static int CurrentDefense(this ShipPartCollection shipParts)
        {
            return shipParts.Shields.Sum(x => x.Defense);
        }
    }
}