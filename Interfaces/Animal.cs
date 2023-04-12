namespace Interfaces
{
    public class Animal : IAnimal
    {
        public bool Walks { get; set; } = true;

        public bool Rests { get; set; } = true;

        public bool Eats { get; set; } = true;
    }
}
