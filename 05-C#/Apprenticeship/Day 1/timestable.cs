using System;

namespace timestable
{
    class Program 
    {
        static void Main()
        {
            Console.Write("Enter a value between 1 and 12: ");
            Int32 number = Convert.ToInt32(Console.ReadLine());

            for (int i=1; i < number; i++)
            {
                String result = Convert.ToString(number * i);
                Console.Write("{0} x {1} = {2} \n", i, number, result);
            }
        }
    }
}