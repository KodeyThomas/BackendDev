using System;

namespace CSProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("code goes brrr");
            Console.WriteLine("What's Your First Name? ");
            String fName = Console.ReadLine();
            Console.WriteLine("Do You Have any Middle Names? (Type Yes if you do) ");
            String doesMNameExist = Console.ReadLine();

            if (doesMNameExist == "Yes" | doesMNameExist == "yes") {
                Console.WriteLine("What is Your Middle Name? ");
                String mName = Console.ReadLine();

                Console.WriteLine("What is Your Last Name? ");
                String tName = Console.ReadLine();

                Console.WriteLine("Hi {0} {1} {2}", fName, mName, tName);
                Console.ReadKey();
            } else {
                Console.WriteLine("What is Your Last Name? ");
                String tName = Console.ReadLine();

                Console.WriteLine("Hi {0} {1}", fName, tName);
                Console.ReadKey();
            }

        }
    }
}