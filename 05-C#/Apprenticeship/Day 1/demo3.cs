using System;

namespace demo3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Name: ");
            String input = Console.ReadLine();

            switch(input) {
                case "Kodey":
                    Console.WriteLine("Hello Kodey!");
                    break;
                case "Thomas":
                    Console.WriteLine("Hello Thomas!");
                    break;
                default:
                    Console.WriteLine("Oh! I Don't Know You... Well anyways Hi {0}", input);
                    break;
            }
        }
    }
}