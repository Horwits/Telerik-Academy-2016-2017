namespace SoftwareAcademy
{
    using System.Collections.Generic;
    using System.Text;

    using System.Linq;

    public class Teacher : ITeacher
    {
        private string name;
        private ICollection<ICourse> courses;

        public Teacher(string name)
        {
            this.Name = name;
            this.courses = new List<ICourse>();
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

        public void AddCourse(ICourse course)
        {
            this.courses.Add(course);
        }

        public override string ToString()
        {
            // Teacher: Name=(teacher name); Courses=[(course names – comma separated)]

            var printInfo = new StringBuilder();

            printInfo.Append(string.Format("Teacher: Name={0}", this.Name));

            if (this.courses.Count > 0)
            {
                var names = new List<string>();

                foreach (var item in this.courses)
                {
                    names.Add(item.Name.ToString());
                }
                printInfo.Append("; ");
                printInfo.Append("Courses=[" + string.Join(", ", names) + "]");
            }

            return printInfo.ToString();
        }
    }
}