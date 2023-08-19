using TaxCalculatorVisitorPattern.Interfaces;

namespace TaxCalculatorVisitorPattern.Models
{
    public class FirstTierTaxVisitor : ITaxVisitor
    {
        public decimal ApplyTax(IncomeTax incomeTax)
        {
            if (incomeTax.Income > Constants.Tax.FIRST_TIER_INCOME) // $14,000.00
            {
                incomeTax.Tax = Constants.Tax.FIRST_TIER_INCOME * Constants.Tax.FIRST_TIER_RATE; // $14,000.00 * 10.5%
            }
            else
            {
                incomeTax.Tax = incomeTax.Income * Constants.Tax.FIRST_TIER_RATE; // Income provided * 10.5% 
            }

            return incomeTax.Tax;
        }
    }
}
