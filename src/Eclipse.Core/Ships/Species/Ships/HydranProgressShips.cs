namespace Eclipse.Core
{
    public static class HydranProgressShips
    {
        public const SpecieColor Color = SpecieColor.Blue;

        public static Interceptor Interceptor => new Interceptor(
            new BaseStats(movement: 0, initiative: 2, computers: 0, defense: 0, power: 0),
            Color,
            slots: 4,
            cost: 3,
            EnergySources.NuclearSource,
            Cannons.IonCannon,
            Drives.NuclearDrive,
            ShipPart.Empty
        );

        public static Cruiser Cruiser => new Cruiser(
            new BaseStats(movement: 0, initiative: 1, computers: 1, defense: 0, power: 0),
            Color,
            slots: 6,
            cost: 5,
            Computers.ElectronComputer,
            EnergySources.NuclearSource,
            Cannons.IonCannon,
            Hulls.Hull,
            ShipPart.Empty,
            Drives.NuclearDrive
        );

        public static Dreadnought Dreadnought => new Dreadnought(
            new BaseStats(movement: 0, initiative: 0, computers: 0, defense: 0, power: 0),
            Color,
            slots: 8,
            cost: 8,
            Computers.ElectronComputer,
            EnergySources.NuclearSource,
            Cannons.IonCannon,
            Hulls.Hull,
            Cannons.IonCannon,
            Hulls.Hull,
            ShipPart.Empty,
            Drives.NuclearDrive
        );

        public static Starbase StarBase => new Starbase(
            new BaseStats(movement: 0, initiative: 4, computers: 0, defense: 0, power: 3),
            Color,
            slots: 5,
            cost: 3,
            Computers.ElectronComputer,
            Hulls.Hull,
            ShipPart.Empty,
            Cannons.IonCannon,
            Hulls.Hull
        );
    }
}