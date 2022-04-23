namespace Eclipse.Core
{
    public static class Shields
    {
        public static Shield GaussShield => new Shield("Gauss Shield", initiative: 0, energyConsumption: 0, defense: 1);
        public static Shield PhaseShield => new Shield("Phase Shield", initiative: 1, energyConsumption: 1, defense: 2);
    }
}