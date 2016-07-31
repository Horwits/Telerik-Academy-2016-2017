namespace School
{
    using System;
    using System.Collections.Generic;

    using Validation;

    public class School
    {
        private string name;

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

        //private readonly ICollection<Student> students;

        //private readonly ICollection<Student> courses;

        //public ICollection<Student> Students
        //{
        //    get
        //    {
        //        return this.students;
        //    }
        //}

        //public ICollection<Student> Courses
        //{
        //    get
        //    {
        //        return this.courses;
        //    }
        //}

        //public void AddCourse(Course course)
        //{

        //}

        //public void RemoveCourse(Course course)
        //{

        //}
    }
}
