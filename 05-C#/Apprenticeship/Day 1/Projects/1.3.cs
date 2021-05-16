using System;

namespace demo3
{
    class Program
    {
        static void Main()
        {
            Console.Write("Please Enter a word with 5 or more letters: ");
            String Input = Console.ReadLine();

            Console.Write("Letters: {0}, First Letter: {1}, Third Letter: {2}, Last Letter: {3}", Input.Length, Input.Substring(0,1), Input.Substring(2,1), Input.Substring(Input.Length -1));
        }
    }
}