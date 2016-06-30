namespace PersonClass
{
    public class Person
    {
        public Person(int? age, string name)
        {
            this.Age = age;
            this.Name = name;
        }

        public int? Age { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            var prinAge = this.Age == null ? "[Age: Not Specified ]" : this.Age.ToString() + " yrs";
            var printName = this.Name == null ? "[Name: Not Specified ]" : this.Name;

            return printName + " " + prinAge;
        }
    }
}