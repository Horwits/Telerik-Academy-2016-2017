namespace LinqQueries.Models.School
{
    public class Group
    {
        public Group(uint groupNumber, string departmentName)
        {
            this.GroupNumber = groupNumber;
            this.DepartmentName = departmentName;
        }

        public uint GroupNumber { get; set; }

        public string DepartmentName { get; set; }

        public override string ToString()
        {
            return "Group number: " + this.GroupNumber + "\n\r" + "Department name: " + this.DepartmentName;
        }
    }
}
