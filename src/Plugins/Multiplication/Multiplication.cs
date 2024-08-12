using CalculatorApp.Services;
using System.ComponentModel.Composition;

namespace Multiplication;

[Export(typeof(IOperation))]
public class Multiplication : IOperation
{
    public string Symbol => "*";

    public double Operate(double a, double b)
    {
        return a * b;
    }
}
