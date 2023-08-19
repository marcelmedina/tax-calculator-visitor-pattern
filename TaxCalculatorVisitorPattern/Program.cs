using TaxCalculatorVisitorPattern.Interfaces;
using TaxCalculatorVisitorPattern.Models;

var incomeTax = new IncomeTax()
{
    Income = 80000m
};

var visitors = new List<ITaxVisitor>
{
    new FirstTierTaxVisitor(),
    new SecondTierTaxVisitor(),
    new ThirdTierTaxVisitor(),
    new FourthTierTaxVisitor(),
    new FifthTierTaxVisitor()
};

var taxCalculator = new TaxCalculator(incomeTax);

foreach (var visitor in visitors)
{
    taxCalculator.CalculateTax(visitor);
}

Console.WriteLine($"Income Tax: {taxCalculator.GetIncomeTax().Tax}");