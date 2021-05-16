using System;

namespace demo23
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter weight of parcel in grams: ");
            Int32 weightInGrams = Convert.ToInt32(Console.ReadLine());

            if (weightInGrams <= 1000)
            {
                Console.WriteLine("Parcel weighing {0} gramms will cost £{1} to send!", weightInGrams, "5.70");
            }
            if (weightInGrams <= 2000)
            {
                Console.WriteLine("Parcel weighing {0} gramms will cost £{1} to send!", weightInGrams, "8.95");
            }
            if (weightInGrams <= 5000)
            {
                Console.WriteLine("Parcel weighing {0} gramms will cost £{1} to send!", weightInGrams, "15.85");
            }
            if (weightInGrams <= 10000)
            {
                Console.WriteLine("Parcel weighing {0} gramms will cost £{1} to send!", weightInGrams, "20.25");
            }
            else
            {
                Console.WriteLine("Parcel weighing {0} gramms will cost £{1} to send!", weightInGrams, "33.40");
            }
        }
    }
}