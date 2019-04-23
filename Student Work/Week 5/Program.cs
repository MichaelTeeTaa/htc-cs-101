using System;

namespace Week_5
{
    class Program
    {
         public static void Main(string[] args)
        {
            int returnValue = 0;

            Console.WriteLine("Enter A:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter B:");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What operation to perform?");
            string operation = Console.ReadLine();

            if (operation == "+" || operation == "addition" || operation == "Addition" || operation == "add" || operation == "Add") {
               returnValue = AddNumbers(a, b);
            }
            


            else if (operation == "-" || operation == "subtraction" || operation == "Subtraction" || operation == "sub" || operation == "Sub") 
            {
                returnValue = SubtractNumbers(a, b);
            }
            Console.WriteLine(returnValue);
        }


        public static int AddNumbers(int integer1 , int integer2) 
        {
            return integer1 + integer2;
            
        }

        public static int SubtractNumbers(int integer1 , int integer2)
        {
            return integer1 - integer2;
        }
    }
}
