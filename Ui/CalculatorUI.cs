using BasicKonsolenTaschenrechner.Interfaces;
using BasicKonsolenTaschenrechner.Models;

namespace BasicKonsolenTaschenrechner.Ui
{
    public class CalculatorUI
    {
        private readonly Calculator _calculator;

        public CalculatorUI()
        {
            _calculator = new Calculator();
        }

        public void Start()
        {
            Console.WriteLine("Simple Calculator");
            Console.WriteLine("----------------");

            try
            {
                Console.Write("Enter first number: ");
                if (!double.TryParse(Console.ReadLine(), out double firstNumber))
                {
                    Console.WriteLine("Invalid number input.");
                    return;
                }

                Console.Write("Enter operation (+, -, *, /): ");
                string operationSymbol = Console.ReadLine();

                Console.Write("Enter second number: ");
                if (!double.TryParse(Console.ReadLine(), out double secondNumber))
                {
                    Console.WriteLine("Invalid number input.");
                    return;
                }

                ICalculatorOperation operation = GetOperation(operationSymbol);
                if (operation == null)
                {
                    Console.WriteLine("Invalid operation.");
                    return;
                }

                double result = _calculator.PerformOperation(firstNumber, secondNumber, operation);
                Console.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }

        private ICalculatorOperation GetOperation(string operationSymbol)
        {
            return operationSymbol switch
            {
                "+" => new Addition(),
                "-" => new Subtraction(),
                "*" => new Multiplication(),
                "/" => new Division(),
                _ => null,
            };
        }
    }
}
