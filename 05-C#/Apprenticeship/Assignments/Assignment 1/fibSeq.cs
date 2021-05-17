using System;

namespace assignment1
{
    class Program
    {
        public static void Main(string []args)
        {
			int a;
			int b;
			int length;
			
            Console.WriteLine("Enter the length of the Sequence: ");
            length = Convert.ToInt32(Console.ReadLine());  
            int[] array = new int[length];
			
            Console.WriteLine("Enter the first number to start Sequence: ");
			a = Convert.ToInt32(Console.ReadLine());  
			
            Console.WriteLine("Enter the second number to start Sequence: ");
            b = Convert.ToInt32(Console.ReadLine());  

            array[0] = a;
            array[1] = b;

            for(int counter = 0; counter < length; counter++)
            {
                int c = array[counter] + array[counter + 1];
                array[counter + 2] = c;
            }
            Console.WriteLine("{0}", array);
        }
    }
}