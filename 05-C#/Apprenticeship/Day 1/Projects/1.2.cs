using System;

namespace demo2
{
    class Program 
    {
        static void Main()
        {
            Console.Write("Enter Length of Rectangle");
            Int32 length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Width of Rectangle");
            Int32 width = Convert.ToInt32(Console.ReadLine());

            Int32 area = length * width;
            Int32 perimeter = (length + length) + (width + width);

            Console.Write("Area: {0}, Perimeter: {1}", area, perimeter);
        }
    }
}