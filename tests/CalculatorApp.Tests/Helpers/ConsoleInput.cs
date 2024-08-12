namespace CalculatorApp.Tests.Helpers
{
    public class ConsoleInput : IDisposable
    {
        private readonly StringReader _stringReader;
        private readonly TextReader _originalInput;

        public ConsoleInput(params string[] inputs)
        {
            _stringReader = new StringReader(string.Join(Environment.NewLine, inputs));
            _originalInput = Console.In;
            Console.SetIn(_stringReader);
        }

        public void Dispose()
        {
            Console.SetIn(_originalInput);
            _stringReader.Dispose();
        }
    }
}
