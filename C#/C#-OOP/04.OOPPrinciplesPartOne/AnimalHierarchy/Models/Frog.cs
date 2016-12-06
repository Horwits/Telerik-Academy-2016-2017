namespace AnimalHierarchy.Models
{
    using AnimalHierarchy.Interfaces;
    using AnimalHierarchy.Types;

    public class Frog : Animal, ISound
    {
        public Frog(string name, uint age, Sex sex) 
            : base(name, age, sex)
        {
        }

        public override string ProduceSound()
        {
            return this.Name + " said: Ribbit!";
        }
    }
}