using TaxCalculatorVisitorPattern.Interfaces;

namespace TaxCalculatorVisitorPattern.Models
{
    public class FourthTierTaxVisitor : ITaxVisitor
    {
        public decimal ApplyTax(IncomeTax incomeTax)
        {
            if (incomeTax.Income > Constants.Tax.FOURTH_TIER_INCOME) // $180,000.00
            {
                incomeTax.Tax += (Constants.Tax.FOURTH_TIER_INCOME - Constants.Tax.THIRD_TIER_INCOME) * Constants.Tax.FOURTH_TIER_RATE; // ($180,000.00 - $70,000.00) * 33%
            }
            else if (incomeTax.Income is > Constants.Tax.THIRD_TIER_INCOME and <= Constants.Tax.FOURTH_TIER_INCOME) // $70,000.00 < x <= $180,000.00
            {
                incomeTax.Tax += (incomeTax.Income - Constants.Tax.THIRD_TIER_INCOME) * Constants.Tax.FOURTH_TIER_RATE; // (Income - $70,000.00) * 33%
            }

            return incomeTax.Tax;
        }
    }
}
