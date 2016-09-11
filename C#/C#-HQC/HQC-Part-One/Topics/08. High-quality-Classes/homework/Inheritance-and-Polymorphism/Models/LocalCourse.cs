using System.Collections.Generic;
using System.Text;
using InheritanceAndPolymorphism.Contracts;

namespace InheritanceAndPolymorphism.Models
{
    public class LocalCourse : Course, ICourse
    {
        public LocalCourse(string name) 
            : base(name)
        {
            this.Lab = null;
        }

        public LocalCourse(string courseName, string teacherName)
            : base(courseName, teacherName)
        {
            this.Lab = null;
        }

        public LocalCourse(string courseName, string teacherName, IList<string> students)
            : base(courseName, teacherName, students)
        {
            this.Lab = null;
        }

        public string Lab { get; set; }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.Append(base.ToString());
            if (this.Lab != null)
            {
                result.Append("; Lab = ");
                result.Append(this.Lab);
            }

            result.Append(" }");

            return result.ToString();
        }
    }
}
