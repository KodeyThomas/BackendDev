using System;

namespace assignment1
{
    class Program
    {
        static void Main()
        {
            double a;
            double b;
            double c;
            float cFloat;
            Int32 cInt;

            Console.WriteLine("Please enter a whole number: ");
            try
            {
                a = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Error must be a WHOLE number.");
                Main();
            }

            Console.WriteLine("Please enter another whole number: ");
            try
            {
                b = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Error must be a WHOLE number.");
                Main();
            }

            double cSquared = (a*a)*(b*b);
            c = Math.sqrt(cSquared);

            try
            {
                cInt = Convert.ToInt32(c);
                Console.WriteLine("Number is a tripple");
            }
            catch (Exception e)
            {
                Console.WriteLine("Number is not a tripple");
                Console.ReadLine();
            }
        }
    }
}