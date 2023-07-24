using System;

namespace Lab6.Kingdoms
{
    public abstract class Animal
    {
        public virtual void Sleep()
        {
            Console.WriteLine("ZZzzzzz");
        }

        public abstract void Breathe();

        public abstract void Move();
    }
}