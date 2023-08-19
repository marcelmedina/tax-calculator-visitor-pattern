using TaxCalculatorVisitorPattern.Interfaces;

namespace TaxCalculatorVisitorPattern.Models
{
    public class SecondTierTaxVisitor : ITaxVisitor
    {
        public decimal ApplyTax(IncomeTax incomeTax)
        {
            if (incomeTax.Income > Constants.Tax.SECOND_TIER_INCOME) // $48,000.00
            {
                incomeTax.Tax += (Constants.Tax.SECOND_TIER_INCOME - Constants.Tax.FIRST_TIER_INCOME) * Constants.Tax.SECOND_TIER_RATE; // ($48,000.00 - $14,000.00) * 17.5%
            }
            else if (incomeTax.Income is > Constants.Tax.FIRST_TIER_INCOME and <= Constants.Tax.SECOND_TIER_INCOME) // $14,000.00 < x <= $48,000.00
            {
                incomeTax.Tax += (incomeTax.Income - Constants.Tax.FIRST_TIER_INCOME) * Constants.Tax.SECOND_TIER_RATE; // (Income - $14,000.00) * 17.5%
            }

            return incomeTax.Tax;
        }
    }
}
