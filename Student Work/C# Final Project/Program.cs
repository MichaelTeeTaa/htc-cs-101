using System;

namespace C__Final_Project
{
    class Program
    {
        static void Main(string[] args)
        
        
        {
            bool replay = true;
            while (replay){
            Console.WriteLine("Would you like to take a quiz?");
            string quizstart = Console.ReadLine();

            if(quizstart == "yes" || quizstart == "Yes")
             {
                Console.WriteLine("Ok, good lets start!");
                quiz();
                replay = false;
                
             }
            else if(quizstart == "no" || quizstart == "No") 
            {
                Console.WriteLine("get out, GET OUT!");
                break;
            
            }  
             
         }

        }

        public static void quiz()
        {
            int startingvalue = 0;

            Console.WriteLine("This quiz will tell you how successful you will be in the future.");
            Console.WriteLine("Here is the first question!");
            Console.WriteLine("1: What kind of personality do you have?");
            Console.WriteLine("A: Crafty");
            Console.WriteLine("B: Generous");
            Console.WriteLine("C: Rude"); 
            
            string Personality = Console.ReadLine();
            if(Personality == "Crafty" ){ 
                startingvalue++; 
            }
            else if (Personality == "Generous"){
                startingvalue+=2;
            }
            else if (Personality == "Rude"){
                startingvalue--;
            }

            Console.WriteLine("2: How much free time do you use to do school work?");
            Console.WriteLine("A: A lot of time");
            Console.WriteLine("B: Moderate amount of time");
            Console.WriteLine("C: Barely any time");
            
            string schoolWork = Console.ReadLine();
             if(schoolWork == "Moderate amount of time" ){ 
                startingvalue++; 
            }
            else if (schoolWork == "A lot of time"){
                startingvalue+=2;
            }
            else if (schoolWork == "Barely any time"){
                startingvalue--;
            }

            Console.WriteLine("3: How is your social life?");
            Console.WriteLine("A: I have a small group of friends");
            Console.WriteLine("B: What friends?");
            Console.WriteLine("C: I can't count how many friends I have");

            string social = Console.ReadLine();
             if(social == "I have a small group of friends" ){ 
                startingvalue++; 
            }
            else if (social == "I can't count how many friends I have"){
                startingvalue+=2;
            }
            else if (social == "What friends?"){
                startingvalue--;
            }

            Console.WriteLine("4: Do you do any sports?");
            Console.WriteLine("A: Yes too many");
            Console.WriteLine("B: exercise i thought you said extra fries");
            Console.WriteLine("C: I participate in a moderate amount of sports.");

            string social = Console.ReadLine();
             if(social == "I participate in a moderate amount of sports." ){ 
                startingvalue++; 
            }
            else if (social == "Yes too many"){
                startingvalue+=2;
            }
            else if (social == "exercise i thought you said extra fries"){
                startingvalue--;
            }

            

            





        } 
        
                

    }
}
