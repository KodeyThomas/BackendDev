using System;

namespace array
{
    class Program 
    {
        static void Main()
        {
            string[] names = new string[] {"Fred", "Sue", "Bill", "James"};
            int numNames = 4;
            string searchName = "George";
            bool found = false;
            
            for (int i = 0; i < numNames; i++)
            {
                if(names[i]==searchName)
                {
                    found = true;
                    Console.WriteLine("Name Found: item = {0}", i +1);
                    break;
                }
            }
            if(!found){
                Console.WriteLine("Name not found!");
            }
        }
    }
}