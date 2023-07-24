using System;

namespace Lab6.Kingdoms.Classes.Species
{
    internal class FlyingFish : Animal, IFlyable, ISwimmable
    {
        public void Fly()
        {
            Console.WriteLine("Glide through the air!");
        }

        public void Swim()
        {
            Console.WriteLine("Swim gracefully in the water!");
        }

        public override void Breathe()
        {
            Console.WriteLine("Breathing through gills.");
        }

        public override void Move()
        {
            Console.WriteLine("Movin through the water.");
        }
    }
}
