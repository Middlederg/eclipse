namespace Eclipse.Core
{
    public static class HullExtensions
    {
        public static bool HasActiveHulls(this ShipPartCollection shipParts)
        {
            return shipParts.Hulls.Any(x => !x.IsDestroyed);
        }

        public static int CurrentStrength(this ShipPartCollection shipParts)
        {
            return shipParts.Hulls.Sum(x => x.CurrentPoints);
        }

        public static Hull GetFirstActive(this ShipPartCollection shipParts)
        {
            return shipParts.Hulls.First(x => !x.IsDestroyed);
        }
    }
}