namespace TaxCalculatorVisitorPattern
{
    public class Constants
    {
        public class Tax
        {
            public const decimal FIRST_TIER_INCOME = 14000m;
            public const decimal SECOND_TIER_INCOME = 48000m;
            public const decimal THIRD_TIER_INCOME = 70000m;
            public const decimal FOURTH_TIER_INCOME = 180000m;

            public const decimal FIRST_TIER_RATE = 0.105m;
            public const decimal SECOND_TIER_RATE = 0.175m;
            public const decimal THIRD_TIER_RATE = 0.30m;
            public const decimal FOURTH_TIER_RATE = 0.33m;
            public const decimal FIFTH_TIER_RATE = 0.39m;
        }
    }
}
