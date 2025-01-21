using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial_Calculation_using_Methods
{
    internal class Program
    {
        static long CalculateFactorial(int number)
        {
            if (number == 0 || number == 1)
                return 1;
            return number * CalculateFactorial(number - 1);
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a positive integer to calculate its factorial: ");
            int input = Convert.ToInt32(Console.ReadLine());

            if (input < 0)
            {
                Console.WriteLine("Factorial is not defined for negative numbers.");
            }
            else
            {
                long factorial = CalculateFactorial(input);
                Console.WriteLine($"The factorial of {input} is: {factorial}");
            }
        }
    }
}
