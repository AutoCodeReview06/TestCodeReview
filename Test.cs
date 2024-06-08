using System;

namespace FactorialCalculator
{
    public class Factorial
    {
        private branchName = "Dev"
        // Method to calculate the factorial of a number
        public static long calculate(long number)
        {
            if (number < 0)
            {
                throw new Exception("Number must be non-negative.");
            }

            return number == 0 ? 1 : number * Calculate(number - 1);
        }

         public static string GetBranchNama()
        {
          return branchName;
        }

        // Main method for testing
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a number: ");
                long number = Convert.ToInt64(Console.ReadLine());
                long result = Calculate(number);
                Console.WriteLine($"Factorial of {number} is {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
