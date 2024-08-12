using CalculatorApp.Services;
using System.ComponentModel.Composition;

namespace Division;

[Export(typeof(IOperation))]
public class Division : IOperation
{
    public string Symbol => "/";

    public double Operate(double a, double b)
    {
        if (b == 0) throw new DivideByZeroException("Cannot divide by zero.");
        return a / b;
    }
}