using CalculatorApp.Services;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Reflection;

namespace CalculatorApp
{
    public class CalculatorApp
    {
        [ImportMany]
        public IEnumerable<IOperation> Operations { get; set; } = Enumerable.Empty<IOperation>();

        public CalculatorApp()
        {
            // Create an AggregateCatalog to load plugins from a directory
            var catalog = new AggregateCatalog();

            // Load the main application assembly (in case there are built-in operations)
            catalog.Catalogs.Add(new AssemblyCatalog(typeof(CalculatorApp).Assembly));

            // Load the plugin assemblies from the "Plugins" directory
            var pluginsPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Plugins");
            if (Directory.Exists(pluginsPath))
            {
                var directoryCatalog = new DirectoryCatalog(pluginsPath);
                catalog.Catalogs.Add(directoryCatalog);
            }

            var container = new CompositionContainer(catalog);
            container.ComposeParts(this);
        }

        public void Run()
        {
            Console.Write("Enter the first number: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Available operations:");
            foreach (var operation in Operations)
            {
                Console.WriteLine($"{operation.Symbol} - {operation.GetType().Name}");
            }

            Console.Write("Enter an operation symbol: ");
            string symbol = Console.ReadLine();

            var selectedOperation = Operations.FirstOrDefault(op => op.Symbol == symbol);

            if (selectedOperation != null)
            {
                double result = selectedOperation.Operate(a, b);
                Console.WriteLine($"Result: {result}");
            }
            else
            {
                Console.WriteLine("Invalid operation symbol.");
            }
        }
    }

}
