using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SimpleCalculater
{
    public class CalculationEngine
    {
        public double Calculate(double Num1, double Num2, string Operater)
        {
            double result;
            switch (Operater.ToLower())
            {
                case "add":
                case "+":
                    result = Num1 + Num2;
                    break;
                case "substract":
                case "-":
                    result = Num1 - Num2;
                    break;
                case "multiply":
                case "*":
                    result = Num1 * Num2;
                    break;
                case "divide":
                case "/":
                    result = Num1 / Num2;
                    break;
                default:
                    throw new InvalidOperationException("Specified operator is not recognized");
            }

            return result;
        }
    }
}
