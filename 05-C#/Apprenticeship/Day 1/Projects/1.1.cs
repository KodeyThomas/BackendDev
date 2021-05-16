using System;

namespace demo1 
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a Whole Number: ");
            Int32 fNumber = Convert.ToInt32(Console.ReadLine()); 

            Console.Write("Enter another Whole Number: ");
            Int32 sNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("{0} x {1} = {2}", fNumber, sNumber, fNumber * sNumber);
        }
    }
}