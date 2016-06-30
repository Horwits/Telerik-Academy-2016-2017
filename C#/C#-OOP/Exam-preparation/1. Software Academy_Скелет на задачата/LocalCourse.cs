using System.Text;

namespace SoftwareAcademy
{
    public class LocalCourse : Course, ICourse, ILocalCourse
    {
        private string lab;

        public LocalCourse(string name, ITeacher teacher)
            : base(name, teacher)
        {
        }

        public LocalCourse(string name, ITeacher teacher, string lab)
            : base(name, teacher)
        {
            this.Lab = lab;
        }

        public string Lab
        {
            get
            {
                return this.lab;
            }

            set
            {
                Validation.ValidateString(value);
                this.lab = value;
            }
        }

        public override string ToString()
        {
            var printInfo = new StringBuilder();

            /*LocalCourse: Name=OOP; Teacher=Svetlin Nakov; Topics=[Using Classes and Objects, Defining Classes, OOP Principles, Teamwork, Exam Preparation]; Lab=Light*/

            printInfo
                .Append("LocalCourse: ")
                .Append(base.ToString())
                .Append("Lab=" + this.Lab);

            return printInfo.ToString();
        }
    }
}