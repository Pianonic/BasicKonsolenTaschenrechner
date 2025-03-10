using BasicKonsolenTaschenrechner.Interfaces;
using BasicKonsolenTaschenrechner.Models;

namespace BasicKonsolenTaschenrechner.Services
{
    public class CalculatorService
    {
        private readonly Calculator _calculator;

        public CalculatorService(Calculator calculator)
        {
            _calculator = calculator;
        }

        public double PerformOperation(double firstNumber, double secondNumber, ICalculatorOperation operation)
        {
            return _calculator.PerformOperation(firstNumber, secondNumber, operation);
        }
    }
}
