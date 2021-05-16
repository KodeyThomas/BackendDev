using System;

namespace demo4
{
       class Program
       {    
           static void Main()
           {
               Console.Write("Start or Stop? ");
               String input = Console.ReadLine();

               switch(input.ToLower()) {
                   case "start":
                    Console.Write("Starting...");
                    break;
                   case "stop":
                    Console.Write("Stopping...");
                    break;
                   default:
                    Console.Write("Invalid Command... \n");
                    Main();
                    break;
               }
           }
       }

}