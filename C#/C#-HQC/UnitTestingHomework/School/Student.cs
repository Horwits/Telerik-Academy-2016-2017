namespace School
{
    using System;

    using Validation;

    public class Student
    {
        private string name;
        private uint uniqueNumber;

        public Student() 
            : this("default")
        {

        }

        public Student(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                SchoolModelsValidator.ValidateIfNameIsNullOrEmpty(value);

                this.name = value;
            }
        }

        public uint UniqueNumber
        {
            get
            {
                return this.uniqueNumber;
            }

            set
            {
                SchoolModelsValidator.ValidateStudentUniqueNumberRange(value);

                this.uniqueNumber = value;
            }
        }
    }
}