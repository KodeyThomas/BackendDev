using System;

namespace demo22
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter a year: ");
            Int32 year = Convert.ToInt32(Console.ReadLine());

            if(DateTime.IsLeapYear(year))
            {
                Console.WriteLine("{0} is a leap year!", year);
            } else {
                Console.WriteLine("{0} is not a leap year!", year);
            }
        }
    }
}