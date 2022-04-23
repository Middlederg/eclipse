namespace Eclipse.Core
{
    public static class Drives
    {
        public static Drive NuclearDrive => new Drive("Nuclear Drive", initiative: 1, energyConsumption: 1, speed: 1);
        public static Drive FusionDrive => new Drive("Fusion Drive", initiative: 2, energyConsumption: 2, speed: 2);
        public static Drive ImpulseDrive => new Drive("Tachyon Drive", initiative: 3, energyConsumption: 3, speed: 3);

    }
}