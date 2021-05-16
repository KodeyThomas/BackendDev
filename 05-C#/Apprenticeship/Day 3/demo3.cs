using System;

namespace demo3
{
    class Program
    {
        static void Main()
        {
            int[] vals = new int[] {9, 7, 5, 2, 3, 1};
            int numVals = 6;

            for (int i = 0; i < numVals; i++)
            {
                for (int j = 0; j < numVals; j++)
                {
                    if (vals[j] > vals[j+1])
                    {
                        int temp = vals[j];
                        vals[j] = vals[j+1];
                        vals[j+1] = temp;
                    }
                }
            }
            for (int i = 0; i < numVals; i++)
            {
                Console.Write(vals[i] + " ");
            }
            console.WriteLine();
        }
    }
}