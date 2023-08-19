using TaxCalculatorVisitorPattern.Models;

namespace TaxCalculatorVisitorPattern.Interfaces
{
    public interface ITaxVisitor
    {
        decimal ApplyTax(IncomeTax income);
    }
}
