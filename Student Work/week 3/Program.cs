using System;

namespace week_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What grade are you in?");
            int studentGrade =  Convert.ToInt32(Console.ReadLine());

            if (studentGrade <= 5)
            {
                Console.WriteLine("You are in Elementary School!");
            }
            else if (studentGrade <= 8)
            {
                Console.WriteLine("You are in Middle School!");
                
            }
            else if (studentGrade <= 12)
            {
                Console.WriteLine("You are in High School!");
            }
            else 
            {
                Console.WriteLine("You might be in college!");
            }
        }
    }
}
