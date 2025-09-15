using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Use static method directly, no instance needed
                Console.WriteLine("Welcome to Simple Calculator\nEnter  your first number then press Enter:");
                double firstNumber = InputConverter.ConvertInputToNumeric(Console.ReadLine());
                Console.WriteLine("Enter  your Second number then press Enter:");
                double secondNumber = InputConverter.ConvertInputToNumeric(Console.ReadLine());
                Console.WriteLine("Enter operation like + or add number then press Enter:");
                string operation = Console.ReadLine();

                string output = CalculatorEngine.Calculate(operation, firstNumber, secondNumber);
                Console.WriteLine(output);

            }
            catch (Exception ex)
            {
                // Normally, we'd log this error to a file.
                Console.WriteLine(ex.Message);
            }

        }
    }
}
