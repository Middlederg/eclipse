namespace Eclipse.Core
{
    public static class EnergySourceFactory
    {
        public static EnergySource NuclearSource => new EnergySource("Nuclear Source", initiative: 0, energyConsumption: 0, power: 3);

        public static EnergySource FusionSource => new EnergySource("Fusion Source", initiative: 0, energyConsumption: 0, power: 6);

        public static EnergySource TachyonSource => new EnergySource("Tachyon Source", initiative: 0, energyConsumption: 0, power: 9);
    }
}