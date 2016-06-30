using System.Text;

namespace SoftwareAcademy
{
    public class OffsiteCourse : Course, ICourse, IOffsiteCourse
    {
        private string town;

        public OffsiteCourse(string name, ITeacher teacher)
            : base(name, teacher)
        {
        }

        public OffsiteCourse(string name, ITeacher teacher, string town)
            : base(name, teacher)
        {
            this.Town = town;
        }

        public string Town
        {
            get
            {
                return this.town;
            }

            set
            {
                Validation.ValidateString(value);
                this.town = value;
            }
        }

        public override string ToString()
        {
            var printInfo = new StringBuilder();

            printInfo
                .Append("OffsiteCourse: ")
                .Append(base.ToString())
                .Append("Town=" + this.Town);

            return printInfo.ToString();
        }
    }
}