using System;

namespace Week_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many oWo's would you like? oWoWoWo");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num > 0) {
                PrintSmileys(num);
            }
            else {
                Console.WriteLine("Please enter a positive number!");
            }            
            
        }

        public static void PrintSmileys(int numTimes) 
        {
            for(int i = 0; i < numTimes; i++) 
            {
                Console.WriteLine("oWo");
            }
        }
    }
}
