using System;
using System.Threading;

namespace SimpleCalculater
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                InputConverter inputConverter = new InputConverter();
                CalculationEngine calculationEngine = new CalculationEngine();

                double firstNumber = inputConverter.ConvertInputToNumberic(Console.ReadLine());
                double secondNumber = inputConverter.ConvertInputToNumberic(Console.ReadLine());
                string operation = Console.ReadLine();

                double result = calculationEngine.Calculate(firstNumber, secondNumber, operation);

                Console.WriteLine(result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
