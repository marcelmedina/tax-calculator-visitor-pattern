using TaxCalculatorVisitorPattern.Interfaces;

namespace TaxCalculatorVisitorPattern.Models
{
    public class ThirdTierTaxVisitor : ITaxVisitor
    {
        public decimal ApplyTax(IncomeTax incomeTax)
        {
            if (incomeTax.Income > Constants.Tax.THIRD_TIER_INCOME) // $70,000.00
            {
                incomeTax.Tax += (Constants.Tax.THIRD_TIER_INCOME - Constants.Tax.SECOND_TIER_INCOME) * Constants.Tax.THIRD_TIER_RATE; // ($70,000.00 - $48,000.00) * 30%
            }
            else if (incomeTax.Income is > Constants.Tax.SECOND_TIER_INCOME and <= Constants.Tax.THIRD_TIER_INCOME) // $48,000.00 < x <= $70,000.00
            {
                incomeTax.Tax += (incomeTax.Income - Constants.Tax.SECOND_TIER_INCOME) * Constants.Tax.THIRD_TIER_RATE; // (Income - $48,000.00) * 30%
            }

            return incomeTax.Tax;
        }
    }
}
