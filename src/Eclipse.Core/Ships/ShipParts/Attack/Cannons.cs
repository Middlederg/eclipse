namespace Eclipse.Core
{
    public static class Cannons
    {
        public static Cannon IonCannon => new Cannon("Ion Cannon", initiative: 0, energyConsumption: 1, Dice.Yellow);
        public static Cannon PlasmaCannon => new Cannon("Plasma Cannon", initiative: 0, energyConsumption: 2, Dice.Orange);
        public static Cannon SolitonCannon => new Cannon("Soliton Cannon", initiative: 0, energyConsumption: 3, Dice.Blue);
        public static Cannon AntimatterCannon => new Cannon("Antimatter Cannon", initiative: 0, energyConsumption: 4, Dice.Red);
    }
}