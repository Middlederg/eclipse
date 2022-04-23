namespace Eclipse.Core
{
    public static class HullFactory
    {
        public static ShipPart Hull() => new Hull("Hull", initiative: 0, energyConsumption: 0, strength: 1);
        
        public static ShipPart ImprovedHull() => new Hull("Improved Hull", initiative: 0, energyConsumption: 0, strength: 2);
    }

}