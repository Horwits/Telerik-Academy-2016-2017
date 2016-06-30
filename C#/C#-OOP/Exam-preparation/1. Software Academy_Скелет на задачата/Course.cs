namespace SoftwareAcademy
{
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;

    public abstract class Course : ICourse
    {
        private string name;
        protected ICollection<string> topics;

        public Course(string name, ITeacher teacher)
        {
            this.Name = name;
            this.Teacher = teacher;
            this.topics = new List<string>();
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

        public ITeacher Teacher { get; set; }

        public void AddTopic(string topic)
        {
            this.topics.Add(topic);
        }

        public override string ToString()
        {
            var printInfo = new StringBuilder();

            /*LocalCourse: Name=OOP; Teacher=Svetlin Nakov; Topics=[Using Classes and Objects, Defining Classes, OOP Principles, Teamwork, Exam Preparation]; Lab=Light*/

            printInfo.Append("Name=" + this.Name + "; ");
            if (this.Teacher != null)
            {
                printInfo.Append("Teacher=" + this.Teacher.Name + "; ");
            }

            if (this.topics.Count > 0)
            {
                printInfo.Append("Topics=[" + string.Join(", ", this.topics) + "]; ");
            }

            return printInfo.ToString();
        }
    }
}