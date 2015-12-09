namespace RG.Calculator.Console
{
    using System;
    using RG.Calculator.Core;
    
    class Program
    {
        public const string ExitStatement = "exit";

        private static readonly ICalculator Calculator = new PolishNotationCalculator();
        
        static void Main(string[] args)
        {
            string inputLine;
            do
            {
                inputLine = Console.ReadLine();

                if (!string.IsNullOrEmpty(inputLine))
                {
                    try
                    {
                        var result = Calculator.Calculate(inputLine);
                        Console.WriteLine("RESULT: {0}", result);
                    }
                    catch (SyntaxException exception)
                    {
                        Console.WriteLine("Syntax exception: {0}", exception.Message);
                    }
                }

                Console.WriteLine();
            } 
            while (!ExitStatement.Equals(inputLine, StringComparison.InvariantCultureIgnoreCase));
        }
    }
}
