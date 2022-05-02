namespace Eclipse.Core
{
    public static class DiceResultExtensions
    {
        public static int Strikes(this IEnumerable<DiceResult> results) => results.Count(x => x.Success);

        public static IEnumerable<DiceResult> Succeeded(this IEnumerable<DiceResult> results) => results.Where(x => x.Success);
    }

}