namespace Interfaces
{
    public interface IMammal
    {
        bool BornAlive { get; set; }
        bool HasHairOrFur { get; set; }
        bool IsWarmBlooded { get; set; }
        bool ProducesMilk { get; set; }
    }
}