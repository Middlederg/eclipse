namespace Eclipse.Core
{
    public static class ComputerExtensions
    {
        public static int CurrentAttack(this ShipPartCollection shipParts)
        {
            return shipParts.Computers.Sum(x => x.Attack);
        }
    }
}