//-----------------------------------------------------------------------
// <copyright file="Student.cs" company="Telerik">
//      (c)Telerik.
// </copyright>
//-----------------------------------------------------------------------
namespace Methods.Contracts
{
    /// <summary>
    /// Represents the public members of Student class
    /// </summary>
    public interface IStudent
    {
        /// <summary>
        /// Student's first name.
        /// </summary>
        string FirstName { get; set; }

        /// <summary>
        /// Student's first name.
        /// </summary>
        string LastName { get; set; }

        /// <summary>
        /// Student's age.
        /// </summary>
        uint Age { get; set; }

        /// <summary>
        /// Student's other info.
        /// </summary>
        string OtherInfo { get; set; }

        /// <summary>
        /// Finds if student is bigger than other student.
        /// </summary>
        /// <param name="other"> Represents a student. </param>
        /// <returns> Bolean representing if a student is bigger than other student. </returns>
        bool IsOlderThan(IStudent other);
    }
}