using System;

namespace Week_4_Excercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(("Random String" != "Random String") == false);
            Console.WriteLine((15 > 7) == true); 
            Console.WriteLine((27 <= 152) == true);
            Console.WriteLine(("My Name Is Jordan" == "my name is jordan") == false);
            Console.WriteLine((35 >= 35) == true);
            Console.WriteLine((3.1254798 <= 5) == true);
            Console.WriteLine((9001 < 9001) == false);
            Console.WriteLine((false || false) == false);
            Console.WriteLine((true || false) == true || false);
            Console.WriteLine((true && false) == (true && false));
            Console.WriteLine(!(true && false) == true);
            Console.WriteLine((false || (true && true)) == true);
            Console.WriteLine((true && (true && false)) == false);
            Console.WriteLine(((false || !(true || false)) && !false) == false);
            Console.WriteLine((false && (false || true)) == false);
            Console.WriteLine((3.1254798 <= 5 && 9001 < 9001) == false);
            Console.WriteLine(("Random String" != "Random String") || (27 <= 152 && 35 >= 35) == true);
            Console.WriteLine((false || (true && (false | true) || !(true && false) || (true && false))) == true);
        }
    }
}
