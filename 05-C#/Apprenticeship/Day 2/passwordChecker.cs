using System;
using System.Text.RegularExpressions;

namespace passwordChecker
{
    class Program
    {
        static Random rd = new Random();
        internal static string CreateString(int stringLength)
        {
            const string allowedChars = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijkmnopqrstuvwxyz0123456789!@$?_-";
            char[] chars = new char[stringLength];

            for (int i = 0; i < stringLength; i++)
            {
                chars[i] = allowedChars[rd.Next(0, allowedChars.Length)];
            }

            return new string(chars);
        }
        static void checkPassword()
        {
            Console.Clear();

            Console.Write("Please Enter a Password to be checked: ");
            String inputPassword = Console.ReadLine();

            if (inputPassword.Length < 8 || inputPassword.Length > 24)
            {
                Console.WriteLine("Error Password has an invalid length...");
                return;
            }

            if (inputPassword.Contains(" "))
            {
                Console.WriteLine("Password Contains invalid characters...");
                return;
            }
            else {
                // Calculate Points
                Int32 score = inputPassword.Length;

                if(Regex.IsMatch(inputPassword, @"\p{Lu}")) // Upper case
                {
                    score = score + 5;  
                }
                if(Regex.IsMatch(inputPassword, @"\p{Ll}")) // Lower case
                {
                    score = score + 5;
                }
                if(Regex.IsMatch(inputPassword, "^[0-9]+$")) // Arabic Numerical (0-9)
                {
                    score = score + 5;
                }
                if(Regex.IsMatch(inputPassword, @"\W|_")) // Special Characters
                {
                    score = score + 5;
                }
                if(Regex.IsMatch(inputPassword, @"\p{Lu}") && Regex.IsMatch(inputPassword, @"\p{Ll}") && Regex.IsMatch(inputPassword, "^[0-9]+$") && Regex.IsMatch(inputPassword, @"\W|_"))
                {
                    score = score + 10;
                }

                Console.WriteLine("---------------------------");
                Console.WriteLine("Your password score is {0}!", score);
                Console.WriteLine("---------------------------");
            }
        
        }

        static void generatePassword()
        {
           Console.Clear();

           int genNumber;
           for(int i = 0; i < 100; i++)
           {
               int gen = rd.Next(13);
               if (8 <= gen && 12 >= gen)
               {
                   genNumber = gen;
                   String genPassword = CreateString(genNumber);
                   Console.WriteLine("Your Password is : {0}", genPassword);
                   break;
               }
           }
        }

        static void Main()
        {   
            Console.WriteLine("Welcome to the Password Program!");
            Console.WriteLine("--------------------------------");

            while (true)
            {
                Console.WriteLine("a) Check Password");
                Console.WriteLine("b) Generate Password");
                Console.WriteLine("c) Quit");

                Console.Write("Choose Your Selection: ");
                String chosenSelection = Console.ReadLine().ToLower();
                
                switch (chosenSelection)
                {
                    case "a":
                        checkPassword();
                        break;
                    case "b":
                        generatePassword();
                        break;
                    case "c":
                        return;
                    default:
                        Console.WriteLine("Invalid Selection!");
                        break;
                }
            }
        }
    }
}