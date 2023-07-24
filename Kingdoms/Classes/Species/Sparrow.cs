using System;

namespace Lab6.Kingdoms.Classes.Species
{
    internal class Sparrow : Bird, ISoundable
    {
        public override void Breathe()
        {
            Console.WriteLine("I'M BREATHING HERE");
        }

        public override void Move()
        {
            Console.WriteLine("Fly swiftly!");
        }

        public void Sound()
        {
            Console.WriteLine("Chirp chirp!");
        }
    }
}
