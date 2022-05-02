namespace Eclipse.Core
{
    public static class OrionHegemonyShips
    {
        public const SpecieColor Color = SpecieColor.Black;

        public static Interceptor Interceptor => new Interceptor(
            new BaseStats(movement: 0, initiative: 3, computers: 0, defense: 0, power: 1),
            Color,
            slots: 4,
            cost: 3,
            EnergySources.NuclearSource,
            Cannons.IonCannon,
            Drives.NuclearDrive,
            Shields.GaussShield
        );

        public static Cruiser Cruiser => new Cruiser(
            new BaseStats(movement: 0, initiative: 2, computers: 0, defense: 0, power: 2),
            Color,
            slots: 6,
            cost: 5,
            Computers.ElectronComputer,
            EnergySources.NuclearSource,
            Cannons.IonCannon,
            Hulls.Hull,
            Shields.GaussShield,
            Drives.NuclearDrive
        );

        public static Dreadnought Dreadnought => new Dreadnought(
            new BaseStats(movement: 0, initiative: 1, computers: 0, defense: 0, power: 3),
            Color,
            slots: 8,
            cost: 8,
            Computers.ElectronComputer,
            EnergySources.NuclearSource,
            Cannons.IonCannon,
            Hulls.Hull,
            Cannons.IonCannon,
            Hulls.Hull,
            Shields.GaussShield,
            Drives.NuclearDrive
        );

        public static Starbase StarBase => new Starbase(
            new BaseStats(movement: 0, initiative: 5, computers: 0, defense: 0, power: 3),
            Color,
            slots: 5,
            cost: 3,
            Computers.ElectronComputer,
            Hulls.Hull,
            Cannons.IonCannon,
            Shields.GaussShield,
            Hulls.Hull
        );
    }
}