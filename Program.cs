using Lab6.Kingdoms.Classes;
using Lab6.Kingdoms.Classes.Species;

namespace Lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Komodo_Dragon komodoDragon = new Komodo_Dragon();
            Monkey monkey = new Monkey();
            Rhino rhino = new Rhino();
            FlyingFish flyingFish = new FlyingFish();
            Bird sparrow = new Sparrow();

            Console.WriteLine("\nKomodo Dragon:");
            komodoDragon.Move();
            komodoDragon.Breathe();

            Console.WriteLine("\nMonkey:");
            monkey.Move();
            monkey.Breathe();
            monkey.ClimbTree();

            Console.WriteLine("\nRhino:");
            rhino.Walk();
            rhino.Breathe();
            rhino.Charge();

            Console.WriteLine("\nFlying Fish:");
            flyingFish.Breathe();
            flyingFish.Fly();
            flyingFish.Swim();

            Console.WriteLine("\nSparrow:");
            sparrow.Move();
            sparrow.Fly();

        }
    }
}
