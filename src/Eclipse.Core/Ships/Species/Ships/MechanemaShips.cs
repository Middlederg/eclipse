namespace Eclipse.Core
{
    public static class MechanemaShips
    {
        public const SpecieColor Color = SpecieColor.White;

        public static Interceptor Interceptor => new Interceptor(
            new BaseStats(movement: 0, initiative: 2, computers: 0, defense: 0, power: 0),
            Color,
            slots: 4,
            cost: 2,
            Cannons.IonCannon,
            ShipPart.Empty,
            Drives.NuclearDrive,
            EnergySources.NuclearSource
        );

        public static Cruiser Cruiser => new Cruiser(
            new BaseStats(movement: 0, initiative: 1, computers: 0, defense: 0, power: 0),
            Color,
            slots: 6,
            cost: 4,
            Cannons.IonCannon,
            Hulls.Hull,
            Computers.ElectronComputer,
            ShipPart.Empty,
            Drives.NuclearDrive,
            EnergySources.NuclearSource
        );

        public static Dreadnought Dreadnought => new Dreadnought(
            new BaseStats(movement: 0, initiative: 0, computers: 0, defense: 0, power: 0),
            Color,
            slots: 8,
            cost: 7,
            Cannons.IonCannon,
            Hulls.Hull,
            Cannons.IonCannon,
            Hulls.Hull,
            Computers.ElectronComputer,
            ShipPart.Empty,
            Drives.NuclearDrive,
            EnergySources.NuclearSource
        );

        public static Starbase StarBase => new Starbase(
            new BaseStats(movement: 0, initiative: 4, computers: 0, defense: 0, power: 3),
            Color,
            slots: 5,
            cost: 2,
            Cannons.IonCannon,
            Hulls.Hull,
            Computers.ElectronComputer,
            Hulls.Hull,
            ShipPart.Empty
        );
    }
}