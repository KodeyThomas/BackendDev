using System;

namespace demo1
{
    class Program
    {
        static void Main()
        {
            int nRows = 2, nCols = 3;

            int[,] myArray = new int[nRows,nCols];

            for (r = 0; r < nRows; r++)
            {
                for (c = 0; c < nCols; c++)
                {
                    Console.Write("Enter a value for row {0}, col {1}", r+1, c+1);
                    myArray[r, c] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (r = 0; r < nRows; r++)
            {
                for (c = 0; c < nCols; c++)
                {
                    Console.Write("Value for row {0}, col {1}: {2}", r+1, c+1, myArray[r, c]);
                }
            }
        }
    }
}