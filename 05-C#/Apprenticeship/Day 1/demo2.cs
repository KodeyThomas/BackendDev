using System;

namespace demo2 {

    class Program {

        static void Main(string[] args) {
            //Get user to enter two numbers and then multiply them together and output on screen

            Console.WriteLine("Welcome to this Demo thing...");
            Console.WriteLine("Please Enter a Whole Number: ");
            String inputOne = Console.ReadLine();
            Console.WriteLine("Please Enter another Whole Number: ");
            String inputTwo = Console.ReadLine();

            Console.WriteLine("Enter a five letter word: ");
            String inputWord = Console.ReadLine();

            Int32 firstNumber = Convert.ToInt32(inputOne);
            Int32 secondNumber = Convert.ToInt32(inputTwo);

            Int32 multiply = firstNumber * secondNumber;

            String subString = inputWord.Substring(1,1);
            String secondSubString = inputWord.Substring(3,1);

            if (firstNumber > secondNumber) {
                Console.WriteLine("{0} is greater than {1}", firstNumber, secondNumber);
            } else {
                Console.WriteLine("{0} is greater than {1}", secondNumber, firstNumber);
            }

            if (inputWord == "abcde") {
                Console.WriteLine("wow thats the word of the day!");
            }
            
            Console.WriteLine("{0} Times {1} = {2} and the second character of your word was {3} and the fourth is {4}", firstNumber, secondNumber, multiply, subString, secondSubString);

        }
    }
}