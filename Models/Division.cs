using BasicKonsolenTaschenrechner.Interfaces;

namespace BasicKonsolenTaschenrechner.Models
{
    public class Division : ICalculatorOperation
    {
        public double Calculate(double firstNumber, double secondNumber)
        {
            if (secondNumber == 0)
                throw new DivideByZeroException("Division by zero is not allowed.");

            return firstNumber / secondNumber;
        }
    }
}
