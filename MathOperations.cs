using System;

namespace MathOperationApp
{
    // Define a class called MathOperations
    public class MathOperations
    {
        // A void method that takes two integers as parameters
        public void PerformOperation(int num1, int num2)
        {
            // Perform a math operation on the first integer (e.g., multiply it by 2)
            int result = num1 * 2;

            // Display the second integer to the screen
            Console.WriteLine($"The result of the operation on the first integer is: {result}");
            Console.WriteLine($"The second integer is: {num2}");
        }
    }
}
