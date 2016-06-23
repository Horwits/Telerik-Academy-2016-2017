namespace SchoolSystem.Models
{
    using SchoolSystem.Interfaces;

    using Validation;

    public class Student : Person, ICommentable
    {
        private uint classNumber;

        public Student(string name) 
            : base(name)
        {
        }

        public Student(string name, uint classNumber)
            : this(name)
        {
            this.ClassNumber = classNumber;
        }

        public uint ClassNumber
        {
            get
            {
                return this.classNumber;
            }

            set
            {
                Validation.ValidateUInt(value);

                this.classNumber = value;
            }
        }
    }
}
