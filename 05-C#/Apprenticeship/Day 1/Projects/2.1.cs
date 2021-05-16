using System;

namespace demo21
{
    class Program 
    {
        static void Main()
        {
            Console.WriteLine("Please Enter a Whole Number");
            Int32 x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter another Whole Number");
            Int32 y = Convert.ToInt32(Console.ReadLine());

            if (x < y)
            {
                Console.WriteLine("No Need to Rearrange!");
            } else {
                Int32 temp = y;

                y = x;
                x = temp;

                Console.WriteLine("x = {0}, y = {1}, Numbers Reordered!", x, y);
            }
        }
    }
}