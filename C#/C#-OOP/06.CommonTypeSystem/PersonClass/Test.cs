namespace PersonClass
{
    using System;

    internal class Test
    {
        internal static void Main(string[] args)
        {
            var person = new Person(null, "Pesho");

            Console.WriteLine(person);

            person.Age = 25;

            Console.WriteLine(person);

            person.Name = null;

            Console.WriteLine(person);
        }
    }
}
