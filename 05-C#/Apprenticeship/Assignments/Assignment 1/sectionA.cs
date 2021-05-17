using System;

namespace assignment1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a number between 1 and 22: ");
            try
            {
                int userInput = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Please Enter a Whole Number..");
                Main(); // Second times a charm eh
            }
            Console.WriteLine("Enter a Second Number between 1 and 22: ");
            try
            {
                int userInput2 = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Please Enter a Whole Number..");
                Main(); // Second times a charm eh
            }
            // Inputs should be sanitized so no error handling required... (Maybe.. Well i hope so)
            Console.WriteLine("{0} x {1} = {2}", userInput, userInput2, (userInput * userInput2));
            Console.ReadLine();
        }
    }
}