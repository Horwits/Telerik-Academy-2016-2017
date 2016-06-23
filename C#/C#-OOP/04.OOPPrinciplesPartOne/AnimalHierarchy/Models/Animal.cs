namespace AnimalHierarchy.Models
{
    using AnimalHierarchy.Interfaces;
    using Validation;

    public abstract class Animal : ISound
    {
        private string name;
        private uint age;

        public Animal(string name, uint age, Sex sex)
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
                Validation.ValidateString(value);
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
                Validation.ValidateUInt(value);
                this.age = value;
            }
        }

        public virtual Sex Sex { get; private set; }

        public abstract string ProduceSound();
    }
}