using TaxCalculatorVisitorPattern.Interfaces;

namespace TaxCalculatorVisitorPattern.Models
{
    public class TaxCalculator : ITaxCalculator
    {
        private readonly IncomeTax _incomeTax;

        public TaxCalculator(IncomeTax incomeTax)
        {
            _incomeTax = incomeTax;
        }

        public void CalculateTax(ITaxVisitor taxVisitor)
        {
            _incomeTax.Tax = taxVisitor.ApplyTax(_incomeTax);
        }

        public IncomeTax GetIncomeTax()
        {
            return _incomeTax;
        }
    }
}
