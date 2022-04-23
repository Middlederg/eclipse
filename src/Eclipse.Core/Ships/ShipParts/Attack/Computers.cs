namespace Eclipse.Core
{
    public static class Computers
    {
        public static Computer ElectronComputer => new Computer("Electron Computer", initiative: 0, energyConsumption: 0, attack: 1);
        public static Computer PositronComputer => new Computer("Positron Computer", initiative: 1, energyConsumption: 1, attack: 2);
        public static Computer GluonComputer => new Computer("Gluon Computer", initiative: 2, energyConsumption: 2, attack: 3);
    }
}