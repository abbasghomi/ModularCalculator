namespace CalculatorApp.Services
{
    public interface IOperation
    {
        string Symbol { get; }
        double Operate(double a, double b);
    }
}
