namespace School.Validation
{
    using System;
    using System.Collections.Generic;

    internal static class SchoolModelsValidator
    {
        internal static void ValidateStudentsCount(Student student, ICollection<Student> students)
        {
            if (students.Count > 30)
            {
                throw new ArgumentOutOfRangeException("Student");
            }
        }

        internal static void ValidateIfIsNull<T>(T element)
        {
            if (element == null)
            {
                throw new ArgumentNullException();
            }
        }

        internal static void ValidateIfNameIsNullOrEmpty(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Name");
            }
        }

        internal static void ValidateStudentUniqueNumberRange(uint uniqueNumber)
        {
            int minValue = 10000, maxValue = 99999;

            if (minValue >= uniqueNumber || uniqueNumber >= maxValue)
            {
                throw new ArgumentOutOfRangeException("Unique Number");
            }
        }

        internal static void ValidateIfStudentExist(Student student, ICollection<Student> students)
        {
            if (!students.Remove(student))
            {
                throw new ArgumentException("Student", "Is not existing in the current collection.");
            }
        }
    }
}