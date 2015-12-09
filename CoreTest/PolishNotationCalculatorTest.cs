namespace RG.Calculator.Core.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    
    [TestClass]
    public class PolishNotationCalculatorTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Calculate_WhenExpressionIsNull_ShouldThrowArgumentNullException()
        {
            // arrange
            var calculator = new PolishNotationCalculator();

            // act
            calculator.Calculate(null);
        }
    }
}
