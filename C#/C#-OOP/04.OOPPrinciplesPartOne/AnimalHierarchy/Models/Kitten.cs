namespace AnimalHierarchy.Models
{
    using AnimalHierarchy.Interfaces;

    public class Kitten : Cat, ISound
    {
        public Kitten(string name, uint age) 
            : base(name, age, Sex.FeMale)
        {
        }

        public override Sex Sex
        {
            get
            {
                return Sex.FeMale;
            }
        }

        public override string ProduceSound()
        {
            return base.ProduceSound();
        }
    }
}