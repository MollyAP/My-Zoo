using System;

namespace Lab6.Kingdoms.Classes
{
   abstract class Mammal : Animal
    {
        public override void Move()
        {
            Console.WriteLine("Walk on legs!");
        }

        public override void Breathe()
        {
            Console.WriteLine("Breathing with lungs.");
        }
    }

    }

