namespace School
{
    using System;
    using System.Collections.Generic;

    using Validation;

    public class Course
    {
        private readonly ICollection<Student> students;

        public Course()
        {
            students = new List<Student>();
        }

        public IEnumerable<Student> Students
        {
            get
            {
                return this.students;
            }
        }

        public int StudentsCount
        {
            get
            {
                return this.students.Count;
            }
        }

        public void AddStudent(Student student)
        {
            SchoolModelsValidator.ValidateIfIsNull(student);

            SchoolModelsValidator.ValidateStudentsCount(student, this.students);

            this.students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            SchoolModelsValidator.ValidateIfIsNull(student);

            if (this.students.Remove(student))
            {

                this.students.Remove(student);
            }
            else
            {
                SchoolModelsValidator.ValidateIfStudentExist(student, this.students);
            }
        }
    }
}