namespace TaxCalculatorVisitorPattern.Interfaces
{
    public interface ITaxCalculator
    {
        void CalculateTax(ITaxVisitor visitor);
    }
}
