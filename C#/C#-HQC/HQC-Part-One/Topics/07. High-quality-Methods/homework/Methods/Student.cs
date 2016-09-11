//-----------------------------------------------------------------------
// <copyright file="Student.cs" company="Telerik">
//     Telerik (c).
// </copyright>
//-----------------------------------------------------------------------
namespace Methods
{
    using Contracts;

    /// <summary>
    /// Represent template for a student
    /// </summary>
    public class Student : IStudent
    {
        /// <summary>
        /// Creates an instance of a student.
        /// </summary>
        public Student()
        {
            // Default constructor
        }

        /// <summary>
        /// Creates an instance of a student.
        /// </summary>
        /// <param name="firstName"> Represents the first name of a student. </param>
        /// <param name="lastName"> Represents the last name of a student. </param>
        /// <param name="age"> Represents the age of a student. </param>
        public Student(string firstName, string lastName, uint age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        /// <summary>
        /// Student's first name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Student's last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Student's age.
        /// </summary>
        public uint Age { get; set; }

        /// <summary>
        /// Student's other info.
        /// </summary>
        public string OtherInfo { get; set; }

        /// <summary>
        /// Finds if student is bigger than other student.
        /// </summary>
        /// <param name="other"> Represents a student. </param>
        /// <returns> Bolean representing if a student is bigger than other student. </returns>
        public bool IsOlderThan(IStudent other)
        {
            var isOlder = this.Age > other.Age;
            return isOlder;
        }
    }
}
