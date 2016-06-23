namespace SchoolSystem.Models
{
    using System.Collections.Generic;

    using SchoolSystem.Interfaces;
    using Validation;

    public class Class : ICommentable
    {
        private string textIdentifier;
        private string comment;
        private ICollection<Student> students;

        public Class(string textIdentifier)
        {
            this.TextIdentifier = textIdentifier;
            this.students = new List<Student>();
        }

        public string TextIdentifier
        {
            get
            {
                return this.textIdentifier;
            }

            set
            {
                Validation.ValidateString(value);

                this.textIdentifier = value;
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

        public ICollection<Student> Students
        {
            get
            {
                return this.students;
            }
        }

        public void AddStudent(Student student)
        {
            this.students.Add(student);
        }

        public override string ToString()
        {
            return this.TextIdentifier; 
        }
    }
}
