using System;
using System.Collections.Generic;
namespace Week_9_Code_Along
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the To-Do List!");
            List<string> toDoList = new List<string>();

            while (true)
            {
                Console.WriteLine("Enter a command: ");
                string command = Console.ReadLine();

                if(command == "Add")
                {
                    Console.WriteLine("Enter an item: ");
                    string item = Console.ReadLine();
                    toDoList.Add(item);
                }
                else if(command == "View")
                {
                    ViewList(toDoList);
                }
                else if (command == "Exit")
                {
                    break; 
                }
            }
        }
    
    public static void ViewList(List<string> stringList)
    {
        Console.WriteLine("To Do:");
        foreach (string item in stringList)
        {
            Console.WriteLine("-" + item);
        }
    }
            }

}


