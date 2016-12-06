namespace StudentsAndWorkers
{
    using Validation;

    public abstract class Human
    {
        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                ValidationUtils.ValidateString(value);
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                ValidationUtils.ValidateString(value);
                this.lastName = value;
            }
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }
    }
}
