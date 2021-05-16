using System;

namespace objectDemo
{
    class Speaker 
    {
        public string colour = "Black";
        public int amountOfSpeakers = 2;

        public void playMusic()
        {
            Console.WriteLine("Playing Music...");
        }
    }
    class Program
    {
        static void Main()
        {
            Speaker Speaker = new Speaker();

            Console.WriteLine(Speaker.colour);
            Speaker.playMusic();
        }
    }
}