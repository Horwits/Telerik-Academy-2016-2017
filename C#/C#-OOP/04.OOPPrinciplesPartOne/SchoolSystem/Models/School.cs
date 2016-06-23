namespace SchoolSystem.Models
{
    using System.Collections.Generic;

    using Validation;

    public class School
    {
        private ICollection<Class> classes;
        private string name;

        public School(string name)
        {
            this.Name = name;
            this.classes = new List<Class>();
        }

        public ICollection<Class> Classes
        {
            get
            {
                return new List<Class>(this.classes);
            }
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

        public void AddClass(Class currentClass)
        {
            this.classes.Add(currentClass);
        }
    }
}
