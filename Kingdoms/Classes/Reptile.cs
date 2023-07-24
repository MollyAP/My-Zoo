using System;

namespace Lab6.Kingdoms.Classes
{
    abstract class Reptile : Animal
    {
        public override void Move()
        {
            Console.WriteLine("Crawl on the ground!");
        }

        public override void Breathe()
        {
            Console.WriteLine("Breathing with lungs.");
        }
    }
}
