using System;

namespace MathOperationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Call the method, passing in two numbers
            mathOps.PerformOperation(5, 10);

            // Call the method, specifying the parameters by name
            mathOps.PerformOperation(num1: 7, num2: 15);

            // Wait for user input to close the console
            Console.ReadLine();
        }
    }
}

