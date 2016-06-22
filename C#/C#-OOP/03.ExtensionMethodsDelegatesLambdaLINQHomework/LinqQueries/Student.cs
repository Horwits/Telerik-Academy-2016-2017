namespace LinqQueries.Models.School
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Student
    {
        private IList<uint> marks;

        public Student() 
            : this(string.Empty, string.Empty, default(uint), string.Empty, string.Empty, default(ulong), default(Group))
        {
            this.marks = new List<uint>();
        }

        public Student(string firstName, string lastName, uint age, string telephone, string email, ulong facultyNumber, Group group)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Telephone = telephone;
            this.EMail = email;
            this.FacultyNumber = facultyNumber;
            this.Group = group;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public uint Age { get; set; }

        public string Telephone { get; set; }

        public string EMail { get; set; }

        public ulong FacultyNumber { get; set; }

        public IList<uint> Marks
        {
            get
            {
                return this.marks;
            }
        }

        public Group Group { get; set; }

        public void AddMark(uint mark)
        {
            this.marks.Add(mark);
        }

        public override string ToString()
        {
            var printInfo = new StringBuilder();
            printInfo.AppendFormat("Full name: {0} {1} ", this.FirstName, this.LastName);
            printInfo.Append(Environment.NewLine);
            printInfo.AppendFormat("Phone: {0} ", this.Telephone);
            printInfo.Append(Environment.NewLine);
            printInfo.AppendFormat("Email: {0} ", this.EMail);
            printInfo.Append(Environment.NewLine);
            printInfo.AppendFormat("Faculty number: {0} ", this.FacultyNumber);
            printInfo.Append(Environment.NewLine);
            printInfo.AppendFormat("Marks: {0} ", this.Marks == null ? " " : string.Join(" ", this.Marks));
            printInfo.Append(Environment.NewLine);
            printInfo.AppendFormat("{0}", this.Group.ToString());

            return printInfo.ToString();
        }
    }
}
