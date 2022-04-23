namespace Eclipse.Core
{
    public static class Missiles
    {
        public static Missile IonCannon => new Missile("Ion missils", initiative: 0, energyConsumption: 1, Dice.Yellow);
        public static Missile PlasmaCannon => new Missile("Plasma missils", initiative: 0, energyConsumption: 2, Dice.Orange);
        public static Missile SolitonCannon => new Missile("Soliton missils", initiative: 0, energyConsumption: 3, Dice.Blue);
        public static Missile AntimatterCannon => new Missile("Antimatter missils", initiative: 0, energyConsumption: 4, Dice.Red);
    }
}