namespace Eclipse.Core
{
    public static class PlantaShips
    {
        public static Interceptor Interceptor => new Interceptor(
            new BaseStats(movement: 0, initiative: 0, computers: 1, defense: 0, power: 2),
            slots: 3,
            cost: 3,
            EnergySources.NuclearSource,
            Cannons.IonCannon,
            Drives.NuclearDrive
        );

        public static Cruiser Cruiser => new Cruiser(
            new BaseStats(movement: 0, initiative: 0, computers: 1, defense: 0, power: 2),
            slots: 5,
            cost: 5,
            EnergySources.NuclearSource,
            Cannons.IonCannon,
            Hulls.Hull,
            ShipPart.Empty,
            Drives.NuclearDrive
        );

        public static Dreadnought Dreadnought => new Dreadnought(
            new BaseStats(movement: 0, initiative: 0, computers: 1, defense: 0, power: 2),
            slots: 7,
            cost: 8,
            EnergySources.NuclearSource,
            Cannons.IonCannon,
            Hulls.Hull,
            Cannons.IonCannon,
            Hulls.Hull,
            ShipPart.Empty,
            Drives.NuclearDrive
        );

        public static Starbase StarBase => new Starbase(
            new BaseStats(movement: 0, initiative: 2, computers: 1, defense: 0, power: 5),
            slots: 4,
            cost: 3,
            Computers.ElectronComputer,
            Cannons.IonCannon,
            Hulls.Hull,
            Hulls.Hull
        );
    }
}