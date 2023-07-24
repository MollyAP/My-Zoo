namespace Lab6.Kingdoms.Classes.Species
{
    class Monkey : Mammal
    {
        public void ClimbTree()
        {
            Console.WriteLine("Climb!!!");
        }

        public override void Move()
        {
            Console.WriteLine("Walk on paws!");
        }

        public override void Breathe()
        {
            Console.WriteLine("I'm breathing!!");
        }
    }
}
