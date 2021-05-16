using System;

namespace codingChallenge
{
    static class Score
    {
        public static Int32 value;
    }
    class Program 
    {
        static void Game()
        {
            Int32 allowedRounds = 4; // 5 Rounds (Starts at 0)
            System.Random random = new System.Random(); 

            // Initialize Arrays
            int[] questions = new int[10];
            int[] answers = new int[5];

            for (int i = 0; i < 10; i++) // Populate for random answers
            {
                int a = random.Next(10);
                questions[i] = a;
            }

            for (int i = 0; i <= allowedRounds; i++) // Questions Input
            {
                Console.Write("{0} x {1} = ? ", questions[i], questions[i+1]);
                Int32 roundAnswer = Convert.ToInt32(Console.ReadLine());

                answers[i] = roundAnswer;
            }

            for (int i = 0; i < allowedRounds; i++) // Check Answers
            {
                if(answers[i] == (questions[i] * questions[i+1]))
                {
                    Score.value++;
                }
            }

        }
        static void Main()
        {
            Console.WriteLine("Welcome to NumberWang (Not based off an early 2000's comedy sketch show.. I Promise");
            Console.WriteLine("-----------------------------------------------------------------------------------");

            Game();

            Console.WriteLine("You score is {0}!", Score.value);
        }
    }
}