using CalculatorApp.Services;
using System.ComponentModel.Composition;

namespace Addition;

[Export(typeof(IOperation))]
public class Addition : IOperation
{
    public string Symbol => "+";

    public double Operate(double a, double b)
    {
        return a + b;
    }
}
