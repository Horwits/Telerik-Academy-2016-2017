namespace SchoolSystem.Models
{
    using SchoolSystem.Interfaces;
    using Validation;

    public abstract class Person : ICommentable
    {
        private string name;
        private string comment;

        public Person(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                Validation.ValidateString(value);

                this.name = value;
            }
        }

        public string Comment
        {
            get
            {
                return this.comment;
            }

            set
            {
                value = Validation.ValidateCommentString(value);

                this.comment = value;
            }
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
