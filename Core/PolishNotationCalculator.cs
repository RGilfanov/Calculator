namespace RG.Calculator.Core
{
    using System;

    public class PolishNotationCalculator : ICalculator
    {
        public double Calculate(string expression)
        {
            if (string.IsNullOrEmpty(expression))
            {
                throw new ArgumentNullException("expression");
            }

            return 0.0;
        }
    }
}
