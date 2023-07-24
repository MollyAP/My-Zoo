using System;

namespace Lab6.Kingdoms.Classes
{
        abstract class Fish : Animal, ISwimmable
    {
            public void Swim()
            {
                Console.WriteLine("Swim with fins!");
            }

            public override void Breathe()
            {
                Console.WriteLine("Breathing with gills.");
            }
        }
    }
