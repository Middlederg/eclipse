namespace Eclipse.Core
{

    public abstract class Ship
    {
        public abstract string Name { get; }
        public abstract string Description { get; }
        public abstract ShipType Type { get; }

        public int Slots { get; }

        public int Cost { get; }

        public ShipPartCollection ShipParts { get; }
        public bool IsDestroyed { get; private set; }

        public BaseStats BaseStats { get; set; }

        public Ship(BaseStats baseStats, int slots, int cost, params ShipPart[] shipParts)
        {
            BaseStats = baseStats;
            Slots = slots;
            Cost = cost;
            ShipParts = new ShipPartCollection(shipParts);
            IsDestroyed = false;
        }

        public IEnumerable<DiceResult> ShootCannons(int defenderShield, IDiceRoller diceRoller) => Shoot(ShipParts.Cannons, defenderShield, diceRoller);
        public IEnumerable<DiceResult> ShootMissils(int defenderShield, IDiceRoller diceRoller) => Shoot(ShipParts.Missils, defenderShield, diceRoller);

        private IEnumerable<DiceResult> Shoot(IEnumerable<IShootable> shootableItems, int defenderShield, IDiceRoller diceRoller)
        {
            foreach (var item in shootableItems)
            {
                foreach (var diceResult in item.Shoot(Computers, defenderShield, diceRoller))
                {
                    yield return diceResult;
                }
            }
        }

        public void SufferDamage(IEnumerable<DiceResult> diceResults)
        {
            foreach (var dice in diceResults)
            {
                foreach (var _ in Enumerable.Range(0, dice.Damage))
                {
                    if (!ShipParts.HasActiveHulls())
                    {
                        IsDestroyed = true;
                        return;
                    }

                    var hull = ShipParts.GetFirstActive();
                    hull.Damage();
                }
            }
        }

        public int Initiative => ShipParts.Initiative + BaseStats.Initiative;

        public int Power => ShipParts.Power + BaseStats.Power;

        public int CurrentStrength => ShipParts.CurrentStrength();

        public int Shields
        {
            get
            {
                if (!ShipParts.Has(ShipPartType.Shield))
                {
                    return BaseStats.Defense;
                }
                return Math.Max(ShipParts.CurrentDefense(), BaseStats.Defense);
            }
        }

        public int Computers
        {
            get
            {
                if (!ShipParts.Has(ShipPartType.Computer))
                {
                    return BaseStats.Computers;
                }
                return Math.Max(ShipParts.CurrentAttack(), BaseStats.Computers);
            }
        }

        public void Repair()
        {
            foreach (var hull in ShipParts.Hulls)
            {
                hull.Repair();
            }
            IsDestroyed = false;
        }

        public bool CanBeAdded(ShipPart shipPart)
        {
            if (shipPart is Drive && this is Starbase)
            {
                return false;
            }
            return shipPart.EnergyConsumption + ShipParts.EnergyConsumption <= Power;
        }

        public void Add(ShipPart shipPart, int position)
        {
            if (CanBeAdded(shipPart))
            {
                if (position >= Slots)
                {
                    throw new ArgumentOutOfRangeException(nameof(position));
                }

                ShipParts.InsertPart(shipPart, position);
            }
        }
    }
}