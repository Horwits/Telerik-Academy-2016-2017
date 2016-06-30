namespace StudentSystem
{
    using System;
    using System.Reflection;
    using System.Text;
    using System.Collections.Generic;

    using StudentSystem.Types;
    public class Student : ICloneable, IComparable<Student>
    {
        public Student(
            string firstName,
            string middleName,
            string lastName,
            string ssn,
            string address,
            string phone,
            string email,
            uint course,
            Speciality speciality,
            University university,
            Faculty faculty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = ssn;
            this.Address = address;
            this.Phone = phone;
            this.Email = email;
            this.Course = course;
            this.Speciality = speciality;
            this.University = university;
            this.Faculty = faculty;
        }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        // "AAA-GG-SSSS"
        public string SSN { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public uint Course { get; set; }

        public Speciality Speciality { get; set; }

        public University University { get; set; }

        public Faculty Faculty { get; set; }

        internal List<int> TestRefProp { get; set; }

        public static bool operator ==(Student first, Student second)
        {
            return object.Equals(first, second);
        }

        public static bool operator !=(Student first, Student second)
        {
            return !object.Equals(first, second);
        }

        public override bool Equals(object obj)
        {
            var student = obj as Student;

            if (student == null)
            {
                throw new ArgumentNullException("Passed object is not a valid Student");
            }

            if (this.FirstName == student.FirstName && this.MiddleName == student.MiddleName && this.LastName == student.LastName && this.SSN == student.SSN)
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            var newHashCode = this.FirstName.GetHashCode() ^
                              this.MiddleName.GetHashCode() ^
                              this.LastName.GetHashCode() ^
                              this.SSN.GetHashCode() ^
                              this.Address.GetHashCode() ^
                              this.Phone.GetHashCode() ^
                              this.Email.GetHashCode() ^
                              this.Course.GetHashCode() ^
                              this.Speciality.GetHashCode() ^
                              this.University.GetHashCode() ^
                              this.Faculty.GetHashCode();

            return newHashCode;
        }

        public override string ToString()
        {
            var printInfo = new StringBuilder();
            printInfo.AppendLine(this.FirstName + " " + this.MiddleName + " " + this.LastName);
            printInfo.AppendLine("SSN: " + this.SSN);
            printInfo.AppendLine("Address: " + this.Address);
            printInfo.AppendLine("Phone: " + this.Phone);
            printInfo.AppendLine("Email: " + this.Email);
            printInfo.AppendLine("University: " + this.University);
            printInfo.AppendLine("Faculty: " + this.Faculty);
            printInfo.AppendLine("Speciality: " + this.Speciality);
            printInfo.Append("Course: " + this.Course);

            return printInfo.ToString();
        }

        public object Clone()
        {
            var copy = this.MemberwiseClone();
            var properties = (this as Student).GetType().GetProperties();
            foreach (var prop in properties)
            {
                var name = prop.Name;
                if (prop.GetType().IsByRef)
                {
                    return copy = DeepCopy(this);
                }
            }

            return copy;
        }

        private static T DeepCopy<T>(T obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException("Object cannot be null");
            }
            return (T)Process(obj);
        }

        private static object Process(object obj)
        {
            if (obj == null)
            {
                return null;
            }

            Type type = obj.GetType();

            if (type.IsValueType || type == typeof(string))
            {
                return obj;
            }
            else if (type.IsArray)
            {
                Type elementType = Type.GetType(
                     type.FullName.Replace("[]", string.Empty));

                var array = obj as Array;

                Array copied = Array.CreateInstance(elementType, array.Length);

                for (int i = 0; i < array.Length; i++)
                {
                    copied.SetValue(Process(array.GetValue(i)), i);
                }

                return Convert.ChangeType(copied, obj.GetType());
            }
            else if (type.IsClass)
            {
                object toret = Activator.CreateInstance(obj.GetType());

                FieldInfo[] fields = type.GetFields(BindingFlags.Public |
                            BindingFlags.NonPublic | BindingFlags.Instance);

                foreach (FieldInfo field in fields)
                {
                    object fieldValue = field.GetValue(obj);
                    if (fieldValue == null)
                        continue;
                    field.SetValue(toret, Process(fieldValue));
                }

                return toret;
            }
            else
            {
                throw new ArgumentException("Unknown type");
            }
        }

        public int CompareTo(Student other)
        {
            if (this.FirstName.CompareTo(other.FirstName) != 0)
            {
                return this.FirstName.CompareTo(other.FirstName);
            }

            if (this.MiddleName.CompareTo(other.MiddleName) != 0)
            {
                return this.MiddleName.CompareTo(other.MiddleName);
            }
            if (this.LastName.CompareTo(other.LastName) != 0)
            {
                return this.LastName.CompareTo(other.LastName);
            }
            if (this.SSN.CompareTo(other.SSN) != 0)
            {
                return this.SSN.CompareTo(other.SSN);
            }

            return 0;
        }
    }
}
