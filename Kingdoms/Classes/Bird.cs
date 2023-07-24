using System;

namespace Lab6.Kingdoms.Classes
{
    public abstract class Bird : Animal, IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Flap wings and fly!");
        }
    }
}

