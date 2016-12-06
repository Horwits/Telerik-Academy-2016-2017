namespace AnimalHierarchy.Models
{
    using AnimalHierarchy.Interfaces;
    using AnimalHierarchy.Types;

    public class AnimalFactory : IAnimalFactory
    {
        public IAnimal GetFrogAnimal(string name, uint age, Sex sex)
        {
            return new Frog(name, age, sex);
        }

        public IAnimal GetDogAnimal(string name, uint age, Sex sex)
        {
            return new Dog(name, age, sex);
        }

        public IAnimal GetCatAnimal(string name, uint age, Sex sex)
        {
            return new Cat(name, age, sex);

        }

        public IAnimal GetKittyAnimal(string name, uint age)
        {
            return new Kitten(name, age);
        }

        public IAnimal GetTomCatAnimal(string name, uint age)
        {
            return new TomCat(name, age);
        }
    }
}