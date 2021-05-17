using System;

namespace assignment1
{
    class Program
    {
        boolean isPrime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;

            var limit = Math.Ceiling(Math.Sqrt(number)); //hoisting the loop limit

            for (int i = 2; i <= limit; ++i)  
            if (number % i == 0)  
                return false;
            return true;

        }

        public static void Main()
        {
            try
            {
                Console.WriteLine("Please enter a number: ");
                int inputNumber = int.Parse(Console.ReadLine());
                bool answerIsPrime = isPrime(inputNumber);

                if(answerIsPrime)
                {
                    Console.WriteLine("Number is Prime!");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("Number is NOT Prime!");
                    Console.ReadLine();
                    break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error!: Please enter a number");
                Main();
            }

        }
    }
}