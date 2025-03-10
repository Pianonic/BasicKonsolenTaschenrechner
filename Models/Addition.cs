using BasicKonsolenTaschenrechner.Interfaces;

namespace BasicKonsolenTaschenrechner.Models
{
    public class Addition : ICalculatorOperation
    {
        public double Calculate(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}
