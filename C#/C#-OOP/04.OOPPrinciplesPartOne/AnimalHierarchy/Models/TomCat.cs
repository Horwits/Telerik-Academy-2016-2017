namespace AnimalHierarchy.Models
{
    using AnimalHierarchy.Interfaces;
    using AnimalHierarchy.Types;

    public class TomCat : Cat, ISound
    {
        public TomCat(string name, uint age)
            : base(name, age, Sex.Male)
        {
        }

        public override Sex Sex
        {
            get
            {
                return Sex.Male;
            }
        }
    }
}