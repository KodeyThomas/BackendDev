using System;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
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
            
            Console.WriteLine("Choose starting place within array: ");
            int startingPoint = Convert.ToInt32(Console.ReadLine());

        double outer = (array[startingPoint] * array[startingPoint + 3]);
        double inner = (array[startingPoint + 1] * array[startingPoint + 2]);

        outer = outer * outer;
        inner = inner * inner;

        double tripple = outer * inner;

        tripple = Math.sqrt(tripple);

        Console.WriteLine("tripple is {0}", tripple);
        Console.ReadLine();
        }
    }
}