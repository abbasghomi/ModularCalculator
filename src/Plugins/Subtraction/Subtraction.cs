using CalculatorApp.Services;
using System.ComponentModel.Composition;

namespace Subtraction;

[Export(typeof(IOperation))]
public class Subtraction : IOperation
{
    public string Symbol => "-";

    public double Operate(double a, double b)
    {
        return a - b;
    }
}
