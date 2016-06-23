namespace StudentsAndWorkers
{
    using Validation;

    public class Student : Human
    {
        private uint grade;

        public Student(string firstName, string lastName)
            : base(firstName, lastName)
        {
        }

        public Student(string firstName, string lastName, uint grade)
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public uint Grade
        {
            get
            {
                return this.grade;
            }

            set
            {
                Validation.ValidateUInt(value);
                this.grade = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + " " + this.Grade;
        }
    }
}
