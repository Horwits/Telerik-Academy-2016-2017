namespace AnimalHierarchy.Models
{
    using AnimalHierarchy.Interfaces;
    using AnimalHierarchy.Types;
    using Validation;

    public abstract class Animal : IAnimal, ISound
    {
        private string name;
        private uint age;

        protected Animal(string name, uint age, Sex sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                ValidationUtils.ValidateString(value);
                this.name = value;
            }
        }

        public uint Age
        {
            get
            {
                return this.age;
            }

            set
            {
                ValidationUtils.ValidateUInt(value);
                this.age = value;
            }
        }

        public virtual Sex Sex { get; private set; }

        public abstract string ProduceSound();
    }
}