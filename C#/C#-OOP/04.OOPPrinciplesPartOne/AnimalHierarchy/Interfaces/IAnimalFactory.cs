namespace AnimalHierarchy.Interfaces
{
    using AnimalHierarchy.Types;

    public interface IAnimalFactory
    {
        IAnimal GetFrogAnimal(string name, uint age, Sex sex);

        IAnimal GetDogAnimal(string name, uint age, Sex sex);

        IAnimal GetCatAnimal(string name, uint age, Sex sex);

        IAnimal GetKittyAnimal(string name, uint age);

        IAnimal GetTomCatAnimal(string name, uint age);
    }
}