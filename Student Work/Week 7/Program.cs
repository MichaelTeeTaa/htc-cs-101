using System;

namespace Week_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 1 and 100: ");

            double number = Convert.ToInt64(Console.ReadLine());

            for(int i = 1; i<=number; i++){

                if( i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FIZZBUZZ");
                }
                else if(i % 3 == 0) {
                    Console.WriteLine("FIZZ");
                    }
                else if(i % 5 == 0) {
                    Console.WriteLine("BuZz");
                }
                else {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
