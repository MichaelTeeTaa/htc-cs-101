using System;

namespace Week_4_Code_Along
{
    class Program
    {
        static void Main(string[] args)
        {
        //     bool snowOnGround = true;
        //     bool foundGloves = true;

        //     if(snowOnGround == true && foundGloves == true)
        //     {
        //         Console.WriteLine("I am going to build a snowman!");
        //     }
        //     else
        //     {
        //         Console.WriteLine("I am staying inside!");
        //     }
            
        bool snowOnGround = true;
        bool FeelingSick = true;
        if (snowOnGround == true || FeelingSick == true)
        {
            Console.WriteLine("I am going to eat some chicken noodle soup.");
        }
        else{
            Console.WriteLine("I do not need soup.");
        }
    }


    }
}
