using System;

namespace Week_7_Excercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a top number: ");
            int topNumber = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            Console.WriteLine("Enter a bottom number: ");
            int bottomNumber = Convert.ToInt32(Console.ReadLine());
            
            for(int i = bottomNumber;i <= topNumber; i++){
                sum = sum + i;
                Console.WriteLine(sum);
            }
        }
    }
}
