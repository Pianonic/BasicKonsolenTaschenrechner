using BasicKonsolenTaschenrechner.Interfaces;

namespace BasicKonsolenTaschenrechner.Models
{
    public class Calculator
    {
        public double PerformOperation(double firstNumber, double secondNumber, ICalculatorOperation operation)
        {
            if (operation == null)
            {
                throw new ArgumentNullException(nameof(operation), "Operation cannot be null.");
            }
            return operation.Calculate(firstNumber, secondNumber);
        }
    }
}
