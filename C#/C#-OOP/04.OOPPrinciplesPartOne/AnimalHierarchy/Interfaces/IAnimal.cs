namespace AnimalHierarchy.Interfaces
{
    using AnimalHierarchy.Types;

    public interface IAnimal : ISound
    {
        string Name { get; set; }

        uint Age { get; set; }

        Sex Sex { get; }
    }
}