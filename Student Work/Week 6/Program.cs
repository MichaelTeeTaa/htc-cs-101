using System;

namespace Week_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a whole number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int result = 1;
            int i = num; 

            while ( i > 0) {
                result *= 1;

                i--;
            }

            Console.WriteLine("Factorial of " +num + " is " +result);
        }
    }
}
