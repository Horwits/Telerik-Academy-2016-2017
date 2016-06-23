namespace SchoolSystem
{
    using System;

    using SchoolSystem.Interfaces;
    using SchoolSystem.Models;

    internal class TestSchoolSystem
    {
        internal static void Main(string[] args)
        {
            //// Person student = new Student(null, 5); // uncomment to see the validation of all strings in this project

            var teacher = new Teacher("Gosho");
            teacher.AddDiscipline(new Discipline("Mathematics"));

            Console.WriteLine(string.Join(" ", teacher.SetOfDisciplines));

            Console.WriteLine(teacher.Teach());

            teacher.Comment = "Comment";

            ICommentable dis = new Discipline("Mathematics");
            dis.Comment = null;

            //// dis.Comment = "comment";

            Console.WriteLine(dis.Comment);

            var school = new School("School name");
            school.AddClass(new Class("XII A"));
            //// school.Classes.Add(new Class("XII A")); //this is showing the encapsulation of all lists in this project

            Console.WriteLine(string.Join(" ", school.Classes));
        }
    }
}
