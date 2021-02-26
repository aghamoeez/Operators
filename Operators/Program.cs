using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 12;

            if (number == 1 )
            {
                Console.WriteLine($"The number is equal to {number}");
            }
            else
            {
                Console.WriteLine($"The number is not equal to 1 the value of number =  {number}");
            }

            if (number is 1)
            {
                Console.WriteLine($"The number is equal to {number} using is Keyword");
            }
            else
            {
                Console.WriteLine($"The number is not equal to 1 the value of number =  {number} using is Keyword");
            }


            Console.WriteLine(number == 1 ? $"The number is equal to { number } using Conditional Operator"
                : $"The number is not equal to 1 the value of number =  {number} using Conditional Operator");



        }
    }
}
