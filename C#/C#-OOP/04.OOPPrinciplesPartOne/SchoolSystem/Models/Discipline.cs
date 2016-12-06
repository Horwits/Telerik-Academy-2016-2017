namespace SchoolSystem.Models
{
    using System;

    using SchoolSystem.Interfaces;
    using Validation;

    public class Discipline : ICommentable
    {
        private string name;
        private uint numberOfLectures;
        private uint numberOfExercises;
        private string comment;

        public Discipline(string name)
        {
            this.Name = name;
        }

        public Discipline(string name, uint numberOfLectures, uint numberOfExercises)
            : this(name)
        {
            this.numberOfLectures = numberOfLectures;
            this.NumberOfExercises = numberOfExercises;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                ValidationUtils.ValidateString(value);

                this.name = value;
            }
        }

        public uint NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }

            set
            {
                ValidationUtils.ValidateUInt(value);

                this.numberOfLectures = value;
            }
        }

        public uint NumberOfExercises
        {
            get
            {
                return this.numberOfExercises;
            }

            set
            {
                ValidationUtils.ValidateUInt(value);

                this.numberOfExercises = value;
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
                value = ValidationUtils.ValidateCommentString(value);

                this.comment = value;
            }
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
