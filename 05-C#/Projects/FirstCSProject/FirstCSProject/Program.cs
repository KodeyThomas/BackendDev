using System;

namespace FirstCSProject
{
    class Program
    {
        static void Main(string[] args)
        {
            ExampleClass exampleObject = new ExampleClass();
            Console.WriteLine(exampleObject.myString);

            Console.ReadKey(); // Pauses until any key is pressed (Keeps process alive until User Input)
        }
    }
}
