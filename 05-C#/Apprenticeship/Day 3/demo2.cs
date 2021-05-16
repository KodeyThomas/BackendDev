using System;

namespace demo2
{
    class Program
    {
        static void Main()
        {
            string[] names = new string[] {"Fred", "Sue", "Bill", "Jane"};
            int numNames = 4;
            string searchName = "George";
            boolean found = false;

            for (int i = 0; i < numNames; i++)
            {
                if(names[i] == searchName)
                {
                    found = true;
                    Console.WriteLine("Name found: item = {0}", i+1);
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("Name not found!");
            }
        }
    }
}