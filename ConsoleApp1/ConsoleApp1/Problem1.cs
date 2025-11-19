using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Calculator
    {
        public double Calculate(double a, double b, string operation)
        {
            switch (operation.ToLower())
            {
                case "add":
                case "+":
                    return a + b;

                case "sub":
                case "-":
                    return a - b;

                case "mul":
                case "*":
                    return a * b;

                case "div":
                case "/":
                    if (b == 0)
                    {
                        throw new DivideByZeroException("Division by zero is not allowed");
                    }
                    return a / b;

                default:
                    throw new ArgumentException("Invalid operation. Use add/sub/mul/div or + - * /");
            }
        }
    }

    class Problem1
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter value a: ");
                string? inputA = Console.ReadLine();
                double a = Convert.ToDouble(inputA);

                Console.Write("Enter value b: ");
                string? inputB = Console.ReadLine();
                double b = Convert.ToDouble(inputB);

                Console.Write("Enter operation (add, sub, mul, div or + - * /): ");
                string operation = Console.ReadLine() ?? "";  

                Calculator calc = new Calculator();
                double result = calc.Calculate(a, b, operation);

                Console.WriteLine("\nResult = " + result);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Enter valid numeric values ");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected error: " + ex.Message);
            }
        }
            
    }
}
