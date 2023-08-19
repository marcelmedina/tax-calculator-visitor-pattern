using TaxCalculatorVisitorPattern.Interfaces;

namespace TaxCalculatorVisitorPattern.Models
{
    public class FifthTierTaxVisitor : ITaxVisitor
    {
        public decimal ApplyTax(IncomeTax incomeTax)
        {
            if (incomeTax.Income > Constants.Tax.FOURTH_TIER_INCOME) // $180,000.00
            {
                incomeTax.Tax += (incomeTax.Income - Constants.Tax.FOURTH_TIER_INCOME) * Constants.Tax.FIFTH_TIER_RATE; // (Income - $180,000.00) * 39%
            }

            return incomeTax.Tax;
        }
    }
}
