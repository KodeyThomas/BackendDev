using System;

namespace demo4
{
    class Program
    {
        static void Main()
        {
            int x,y, result;
            Console.Write("Division. Please enter the numerator: ");
            try {
                x = Convert.ToInt32(Console.ReadLine());
            }
            catch {
                Console.WriteLine("Please enter a whole number: ");
                Main();
            }

            Console.Write("Please enter the denominator: ");
            try {
                y = Convert.ToInt32(Console.ReadLine());
            }
            catch {
                Console.WriteLine("Please enter a whole number: ");
                Main();
            }

            result = x/y;
            Console.WriteLine("Result = {0}", Convert.ToString(result));
        }
    }
}